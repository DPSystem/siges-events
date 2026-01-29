using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaMudBlazor2.Data;
using PruebaMudBlazor2.Shared.Models;
using System.Threading.Tasks;

namespace PruebaMudBlazor2.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosAñoController : ControllerBase
    {
        private readonly SindicatoContext _context;

        public EventosAñoController(SindicatoContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<EventosAño>> CreateEventoAño(EventosAño eventoAño)
        {
            _context.EventosAños.Add(eventoAño);
            await _context.SaveChangesAsync();
            return Ok(eventoAño);
        }

        [HttpGet("byevento/{eventoId:int}")]
        public async Task<ActionResult<List<EventosAño>>> GetEventosAñoByEventoId(int eventoId)
        {
            var eventosAño = await _context.EventosAños.Where(ea => ea.EventoId == eventoId).ToListAsync();
            return Ok(eventosAño);
        }

        [HttpGet("filtered/{eventoId:int}/{estado:int}")]
        public async Task<ActionResult<List<EventosAño>>> GetEventosAñoFiltered(int eventoId, int estado)
        {
            var eventosAño = await _context.EventosAños.Where(ea => ea.EventoId == eventoId && ea.Estado == estado).ToListAsync();
            return Ok(eventosAño);
        }
    }
}
