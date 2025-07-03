using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Server.Services.Sindicato.Interfaces;
using Shared.Models;
using Shared.Models.Sindicato;

[Route("api/[controller]")]
[ApiController]
public class SocioController : ControllerBase
{
    private readonly IMaesocService _maesocService; // obtener el cuil a partir del DNI
    private readonly IDdjjService _ddjjService; //aqui esta la carencia
    private readonly ISoccenService _soccenService; // Ver campor estado apra saber si es socio o no

    public SocioController(
        IMaesocService maesocService,
        IDdjjService ddjjService,
        ISoccenService soccenService
    )
    {
        _maesocService = maesocService;
        _ddjjService = ddjjService;
        _soccenService = soccenService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Maesoc>>> GetSocios()
    {
        return Ok(await _maesocService.GetAllAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Maesoc>> GetSocioById(int id)
    {
        var socio = await _maesocService.GetByIdAsync(id);

        if (socio == null)
        {
            return NotFound();
        }

        return socio;
    }

    [HttpGet("dni/{dni}")]
    public async Task<ActionResult<Maesoc>> GetSocioByDni(string dni)
    {
        var socio = await _maesocService.GetByDniAsync(dni);

        // Console.WriteLine("Nombre: " +socio.MAESOC_NOMBRE);
        if (socio == null)
        {
            return NotFound();
        }

        return socio;
    }

    [HttpGet("carencia/{cuil}")]
    public async Task<bool> GetCarencia(string cuil, string fecha = "01-02-2025")
    {
        return await _ddjjService.GetCarenciaByCuil(cuil, fecha);
    }

    [HttpGet("essocio/{cuil}")]
    public async Task<bool> GetEsSocio(double cuil)
    {
        var soc = await _soccenService.GetSocioByCuil(cuil);
        if (soc == null)
        {
            return false;
        }
        else
        {
            if (soc.SOCCEN_ESTADO == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
