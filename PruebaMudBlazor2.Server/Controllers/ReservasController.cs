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

        // Reemplaza a GetReservaEstado(int NroDeCupon)
        [HttpGet("{nroReserva:int}")]
        public async Task<ActionResult<EventosCupone>> GetReserva(int nroReserva)
        {
            var reserva = await _context.EventosCupones.FirstOrDefaultAsync(x => x.EventCuponNro == nroReserva && x.EventcuponEventoId == 6);
            if (reserva == null)
            {
                return NotFound();
            }
            return Ok(reserva);
        }

        // Reemplaza a GetReservasPendientes()
        [HttpGet("pendientes")]
        public async Task<ActionResult<List<EventosCupone>>> GetReservasPendientes()
        {
            var reservas = await _context.EventosCupones.Where(x => x.Reimpresion == 2).ToListAsync();
            return Ok(reservas);
        }

        // Reemplaza a GetNroDeReserva(double cuil)
        [HttpGet("socio/{cuil:double}")]
        public async Task<ActionResult<int>> GetNroDeReservaPorCuil(double cuil)
        {
            var reserva = await _context.EventosCupones.FirstOrDefaultAsync(x => x.EventcuponEventoId == 6 && x.EventcuponMaesocCuil == cuil);
            if (reserva != null)
            {
                return Ok(reserva.EventCuponNro);
            }
            return Ok(0);
        }

        // Reemplaza a SetReservaMochila
        [HttpPost]
        public async Task<ActionResult<int>> CrearReserva([FromBody] PruebaMudBlazor2.Shared.ReservaRequest request)
        {
            int nroDeCupon = 1;
            if (await _context.EventosCupones.AnyAsync(x => x.EventcuponEventoId == 6))
            {
                nroDeCupon = await _context.EventosCupones.Where(x => x.EventcuponEventoId == 6).MaxAsync(x => x.EventCuponNro) + 1;
            }

            EventosCupone nuevaReserva = new EventosCupone
            {
                EventCuponNro = nroDeCupon,
                EventcuponEventoId = 6,
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
        [HttpGet("{nroReserva:int}/impresion")]
        public async Task<ActionResult<ReservaParaImprimir>> GetReservaParaImprimir(int nroReserva)
        {
            var res = await _context.EventosCupones.FirstOrDefaultAsync(x => x.EventCuponNro == nroReserva && x.EventcuponEventoId == 6);
            if (res == null) return NotFound("Reserva no encontrada.");

            var datosSocio = await _context.Maesocs.FirstOrDefaultAsync(x => x.MaesocCuil == res.EventcuponMaesocCuil);
            if (datosSocio == null) return NotFound("Socio no encontrado.");

            var mochilas = await _context.CuponBenefArticulos.Where(x => x.NroCupon == nroReserva && x.EventoId == 6).ToListAsync();

            var familiaTasks = mochilas.Select(async item => (await _context.Articulos.FindAsync(item.ArticuloId))?.Id.ToString()).ToList();
            var regalosTasks = mochilas.Select(async item => (await _context.Articulos.FindAsync(item.ArticuloId))?.Descripcion).ToList();

            var familiaIds = (await Task.WhenAll(familiaTasks)).Where(id => id != null).ToList();
            var regalosDesc = (await Task.WhenAll(regalosTasks)).Where(desc => desc != null).ToList();

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
        [HttpGet("{nroReserva:int}/fueentregado")]
        public async Task<ActionResult<bool>> YaFueEntregado(int nroReserva)
        {
            var cupon = await _context.EventosCupones.FirstOrDefaultAsync(x => x.EventCuponNro == nroReserva && x.EventcuponEventoId == 6);
            if (cupon != null)
            {
                return Ok(cupon.Reimpresion == 1);
            }
            return Ok(true); // Si no se encuentra el cupón, se asume como "entregado" para evitar problemas.
        }
    }
}
