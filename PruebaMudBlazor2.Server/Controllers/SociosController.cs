using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using PruebaMudBlazor2.Data;
using PruebaMudBlazor2.Shared.Models;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaMudBlazor2.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin")]
    public class SociosController : ControllerBase
    {
        private readonly SindicatoContext _context;

        public SociosController(SindicatoContext context)
        {
            _context = context;
        }

        // Reemplaza a ExisteEmpleado(string? NroDni)
        [HttpGet("{dni}")]
        public async Task<ActionResult<Maesoc>> GetSocioByDni(string dni)
        {
            var empleado = await _context.Maesocs.FirstOrDefaultAsync(x => x.MaesocNrodoc == dni);

            if (empleado == null)
            {
                return NotFound();
            }
            return Ok(empleado);
        }

        // Reemplaza a GetsocioBool(string? NroDni)
        [HttpGet("{dni}/essocio")]
        public async Task<ActionResult<bool>> EsSocioActivo(string dni)
        {
            var socio = await _context.Maesocs.FirstOrDefaultAsync(x => x.MaesocNrodoc == dni);

            if (socio == null)
            {
                return Ok(false);
            }

            var maesoc = await _context.Soccens.FirstOrDefaultAsync(x => x.SoccenCuil == socio.MaesocCuil);

            if (maesoc == null)
            {
                return Ok(false);
            }

            return Ok(maesoc.SoccenEstado == 1);
        }

        [HttpGet("cuil/{cuil:double}")]
        public async Task<ActionResult<Maesoc>> GetSocioByCuil(double cuil)
        {
            var socio = await _context.Maesocs.FirstOrDefaultAsync(x => x.MaesocCuil == cuil);

            if (socio == null)
            {
                return NotFound();
            }

            return Ok(socio);
        }

        // Reemplaza a GetFotoTitular(double NroCuil)
        [HttpGet("{cuil:double}/foto")]
        public async Task<ActionResult<Foto>> GetFotoTitular(double cuil)
        {
            var foto = await _context.Fotos.FirstOrDefaultAsync(x => x.FotosCuil == cuil);
            if (foto == null)
            {
                return NotFound();
            }
            return Ok(foto);
        }

        // Reemplaza a GetCarencia(double cuil)
        [HttpGet("{cuil:double}/carencia")]
        public async Task<ActionResult<bool>> GetCarencia(double cuil)
        {
            DateTime mesDeCarencia = new DateTime(2024, 10, 1);
            var carencia = await _context.Ddjjs.FirstOrDefaultAsync(x => x.Cuil == cuil && x.Periodo >= mesDeCarencia);

            if (carencia != null)
            {
                return Ok(carencia.Item2);
            }
            return Ok(false);
        }

        // Reemplaza a CumpleConAporteMinimo(double cuil)
        [HttpGet("{cuil:double}/aporteminimo")]
        public async Task<ActionResult<bool>> CumpleConAporteMinimo(double cuil)
        {
            decimal aporteMinimo = 0;
            var ultimaDJ = await _context.Ddjjs
                                         .Where(a => a.Cuil == cuil)
                                         .OrderByDescending(x => x.Periodo)
                                         .FirstOrDefaultAsync();

            if (ultimaDJ != null)
            {
                aporteMinimo = Convert.ToDecimal(ultimaDJ.Impo.GetValueOrDefault() + ultimaDJ.Impoaux.GetValueOrDefault()) * 0.02m;
            }

            return Ok(aporteMinimo > 8000);
        }
    }
}
