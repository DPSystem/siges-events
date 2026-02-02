using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaMudBlazor2.Data;
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
    public class ReservasController : ControllerBase
    {
        private readonly SindicatoContext _context;

        public ReservasController(SindicatoContext context)
        {
            _context = context;
        }

                [AllowAnonymous]

                [HttpGet("{nroReserva:int}/{eventosAñoId:int}")]

                public async Task<ActionResult<EventosCupone>> GetReserva(int nroReserva, int eventosAñoId)

                {

                    var reserva = await _context.EventosCupones.FirstOrDefaultAsync(x => x.EventCuponNro == nroReserva && x.EventcuponEventoId == eventosAñoId);

                    if (reserva == null)

                    {

                        return NotFound();

                    }

                    return Ok(reserva);

                }

        

                // Reemplaza a GetReservasPendientes()

                [AllowAnonymous]

                [HttpGet("pendientes")]

                public async Task<ActionResult<List<EventosCupone>>> GetReservasPendientes()

                {

                    var reservas = await _context.EventosCupones.Where(x => x.Reimpresion == 2).ToListAsync();

                    return Ok(reservas);

                }

        

                // Reemplaza a GetNroDeReserva(double cuil)

                [AllowAnonymous]

                [HttpGet("socio/{cuil:double}/{eventosAñoId:int}")]

                public async Task<ActionResult<int>> GetNroDeReservaPorCuil(double cuil, int eventosAñoId)

                {

                    var reserva = await _context.EventosCupones.FirstOrDefaultAsync(x => x.EventcuponEventoId == eventosAñoId && x.EventcuponMaesocCuil == cuil);

                    if (reserva != null)

                    {

                        return Ok(reserva.EventCuponNro);

                    }

                    return Ok(0);

                }

        

                // Reemplaza a SetReservaMochila

                [AllowAnonymous]

                [HttpPost]

                public async Task<ActionResult<int>> CrearReserva([FromBody] PruebaMudBlazor2.Shared.ReservaRequest request)

                {

                    // Get EventosAño entity

                    var eventosAño = await _context.EventosAños.FirstOrDefaultAsync(ea => ea.Id == request.EventosAñoId);

                    if (eventosAño == null)

                    {

                        return BadRequest("EventosAñoId inválido.");

                    }

        

                    int eventoId = eventosAño.Id; // Use the primary key of EventosAño

        

                    int nroDeCupon = 1;

                    if (await _context.EventosCupones.AnyAsync(x => x.EventcuponEventoId == eventoId))

                    {

                        nroDeCupon = await _context.EventosCupones.Where(x => x.EventcuponEventoId == eventoId).MaxAsync(x => x.EventCuponNro) + 1;

                    }

        

                    EventosCupone nuevaReserva = new EventosCupone

                    {

                        EventCuponNro = nroDeCupon,

                        EventcuponEventoId = eventoId, // Use the dynamically fetched EventoId

                        EventcuponMaesocCuil = Convert.ToDouble(request.CuilTitular),

                        EventcuponMaefliaCodfliar = 0,

                        EventCuponFecha = DateTime.Now,

                        UsuarioId = 0,

                        ArticuloId = 0,

                        QuienRetiraCupon = request.NroDeCelular,

                        Reimpresion = request.Estado,

                        EsExepcion = 0,

                    };

        

                    _context.EventosCupones.Add(nuevaReserva);

                    await _context.SaveChangesAsync();

        

                    return Ok(nroDeCupon);

                }

        

                // Reemplaza a GetReservaImpresion

                [AllowAnonymous]

                [HttpGet("{nroReserva:int}/impresion/{eventosAñoId:int}")]

                public async Task<ActionResult<ReservaParaImprimir>> GetReservaParaImprimir(int nroReserva, int eventosAñoId)

                {

                    var res = await _context.EventosCupones.FirstOrDefaultAsync(x => x.EventCuponNro == nroReserva && x.EventcuponEventoId == eventosAñoId);

                    if (res == null) return NotFound("Reserva no encontrada.");

        

                    var datosSocio = await _context.Maesocs.FirstOrDefaultAsync(x => x.MaesocCuil == res.EventcuponMaesocCuil);

                    if (datosSocio == null) return NotFound("Socio no encontrado.");

        

                    var mochilas = await _context.CuponBenefArticulos.Where(x => x.NroCupon == nroReserva && x.EventoId == eventosAñoId).ToListAsync();

        

                    var articuloIds = mochilas.Select(m => m.ArticuloId).ToList();

                    var articulos = await _context.Articulos

                                                  .Where(a => articuloIds.Contains(a.Id))

                                                  .ToListAsync();

        

                    var familiaIds = articulos.Select(a => a.Id.ToString()).ToList();

                    var regalosDesc = articulos.Select(a => a.Descripcion).ToList();

        

                    ReservaParaImprimir resParaImp = new ReservaParaImprimir

                    {

                        NroReserva = res.EventCuponNro.ToString(),

                        NroSocio = int.Parse(datosSocio.MaesocNroafil),

                        ApellidoNombreSocio = datosSocio.Apenom,

                        dni = double.Parse(datosSocio.MaesocNrodoc),

                        Familiares = familiaIds,

                        Regalos = regalosDesc

                    };

        

                    res.Reimpresion = 1;

                    res.FechaDeEntregaArticulo = DateTime.Now;

        

                    await _context.SaveChangesAsync();

        

                    return Ok(resParaImp);

                }

        

                // Reemplaza a YaFueEntregado(int NroDeReserva)

                [AllowAnonymous]

                [HttpGet("{nroReserva:int}/fueentregado/{eventosAñoId:int}")]

                public async Task<ActionResult<bool>> YaFueEntregado(int nroReserva, int eventosAñoId)

                {

                    var cupon = await _context.EventosCupones.FirstOrDefaultAsync(x => x.EventCuponNro == nroReserva && x.EventcuponEventoId == eventosAñoId);

                    if (cupon != null)

                    {

                        return Ok(cupon.Reimpresion == 1);

                    }

                    return Ok(true); // Si no se encuentra el cupón, se asume como "entregado" para evitar problemas.

                }

            }

        }

        