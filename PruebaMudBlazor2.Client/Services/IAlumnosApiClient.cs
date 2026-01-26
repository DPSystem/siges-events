using PruebaMudBlazor2.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using PruebaMudBlazor2.Shared;

namespace PruebaMudBlazor2.Client.Services
{
    public interface IAlumnosApiClient
    {
        Task<List<Alumno>> GetAlumnosPorCuilAsync(double cuil);
        Task<bool> AsignarMochilasAsync(AsignacionMochilaRequest request);
    }
}
