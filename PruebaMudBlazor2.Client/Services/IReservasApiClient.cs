using PruebaMudBlazor2.Shared;
using PruebaMudBlazor2.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PruebaMudBlazor2.Client.Services
{
    public interface IReservasApiClient
    {
        Task<EventosCupone?> GetReservaAsync(int nroReserva);
        Task<List<EventosCupone>> GetReservasPendientesAsync();
        Task<int> GetNroDeReservaPorCuilAsync(double cuil);
        Task<int> CrearReservaAsync(ReservaRequest request); // Usar el DTO del server
        Task<ReservaParaImprimir?> GetReservaParaImprimirAsync(int nroReserva);
        Task<bool> YaFueEntregadoAsync(int nroReserva);
    }
}
