using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using PruebaMudBlazor2.Data;
using PruebaMudBlazor2.Shared; // Para FuncUtiles y AsignacionMochilaRequest
using PruebaMudBlazor2.Shared.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace PruebaMudBlazor2.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin")]
    public class AlumnosController : ControllerBase
    {
        private readonly SindicatoContext _context;

        public AlumnosController(SindicatoContext context)
        {
            _context = context;
        }

        // Reemplaza a GetAlumno(double cuil)
        [HttpGet("{cuil:double}")]
        public async Task<ActionResult<List<Alumno>>> GetAlumnosPorCuil(double cuil)
        {
            var socfliaQuery =
              from a in _context.Socflia.Where(x => x.SocfliaCuil == cuil)
              join b in _context.Maeflia on a.SocfliaCodfliar equals b.MaefliaCodfliar
              join f in _context.Fotos on b.MaefliaCodfliar equals f.FotosCodfliar into fotogroup
              from f in fotogroup.DefaultIfEmpty()
              select new Alumno
              {
                  CuilTitular = cuil,
                  CodiGoDeFamiliar = Convert.ToInt32(b.MaefliaCodfliar),
                  Apenom = $"{b.MaefliaApellido.Trim()} {b.MaefliaNombre.Trim()}",
                  FechaNac = Convert.ToDateTime(b.MaefliaFecnac),
                  Mochila = 0,
                  URLImage = f.FotosCodfliar.ToString() ?? string.Empty,
                  NroSocio = string.Empty,
                  Apellido = string.Empty,
                  Nombre = string.Empty,
                  Domicilio = string.Empty,
                  Telefono = string.Empty,
                  Sexo = string.Empty,
                  Mail = string.Empty,
                  Celular = string.Empty,
                  Foto = string.Empty,
                  Dni = string.Empty,
                  CicloEscolar = string.Empty
              };

            var alumnos = await socfliaQuery.ToListAsync();

            alumnos.ForEach(x =>
            {
                x.URLImage = x.URLImage != null ? $"Pictures/Beneficiarios/{x.URLImage}.png" : "Pictures/Beneficiarios/0.png";
            });

            alumnos.RemoveAll(x => (x.FechaNac.HasValue && FuncUtiles.CalcularEdadMaternal(x.FechaNac.Value)) || x.Edad > 17);

            return Ok(alumnos);
        }

        // Reemplaza a SetAlumnoMochila
        [HttpPost("mochilas")]
        public async Task<IActionResult> AsignarMochilas([FromBody] AsignacionMochilaRequest request)
        {
            if (request == null || request.Alumnos == null)
            {
                return BadRequest("La solicitud es inválida.");
            }

            try
            {
                // Buscar la reserva para obtener el EventoId dinámicamente
                var reserva = await _context.EventosCupones
                                            .AsNoTracking()
                                            .FirstOrDefaultAsync(c => c.EventCuponNro == request.NroDeReserva && c.EventcuponEventoId == request.EventosAñoId);

                if (reserva == null)
                {
                    return BadRequest("El número de reserva no existe.");
                }

                if (reserva.EventcuponEventoId == null)
                {
                    return BadRequest("La reserva no tiene un evento asociado.");
                }

                var eventoId = reserva.EventcuponEventoId; // ID del evento dinámico

                var cbaList = new List<CuponBenefArticulo>();

                foreach (var alumno in request.Alumnos)
                {
                    cbaList.Add(new CuponBenefArticulo
                    {
                        NroCupon = request.NroDeReserva,
                        Cuil = Convert.ToString(alumno.CuilTitular),
                        CodigoFliar = alumno.CodiGoDeFamiliar,
                        ArticuloId = alumno.Mochila, // Guarda el Id de la mochila
                        EventoId = eventoId, // Usar el ID del evento obtenido de la reserva
                        Estado = 0  // 0-NO ENTREGADO, 1-Entregado, 2-Pendiente, 3-NO APROBADO
                    });
                }

                _context.CuponBenefArticulos.AddRange(cbaList);
                await _context.SaveChangesAsync();
                return Ok(true);
            }
            catch (Exception ex)
            {
                // Considerar loguear el error
                return StatusCode(500, "Ocurrió un error interno al asignar las mochilas.");
            }
        }
    }
}