using PruebaMudBlazor2.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PruebaMudBlazor2.Client.Services
{
    public interface ISociosApiClient
    {
        Task<Maesoc?> GetSocioByDniAsync(string dni);
        Task<bool> EsSocioActivoAsync(string dni);
        Task<Foto?> GetFotoTitularAsync(double cuil);
        Task<bool> GetCarenciaAsync(double cuil);
        Task<bool> CumpleConAporteMinimoAsync(double cuil);
    }
}
