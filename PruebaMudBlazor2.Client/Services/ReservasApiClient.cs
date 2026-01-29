using PruebaMudBlazor2.Shared.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using PruebaMudBlazor2.Shared; // Correcto using para ReservaRequest

namespace PruebaMudBlazor2.Client.Services
{
    public class ReservasApiClient : IReservasApiClient
    {
        private readonly HttpClient _httpClient;

        public ReservasApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<EventosCupone?> GetReservaAsync(int nroReserva, int eventosAñoId)
        {
            var response = await _httpClient.GetAsync($"api/reservas/{nroReserva}/{eventosAñoId}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<EventosCupone>();
            }
            return null;
        }

        public async Task<List<EventosCupone>> GetReservasPendientesAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<EventosCupone>>("api/reservas/pendientes") ?? new List<EventosCupone>();
        }

        public async Task<int> GetNroDeReservaPorCuilAsync(double cuil, int eventosAñoId)
        {
            var response = await _httpClient.GetFromJsonAsync<int>($"api/reservas/socio/{cuil}/{eventosAñoId}");
            return response;
        }

        public async Task<int> CrearReservaAsync(ReservaRequest request)
        {
            var response = await _httpClient.PostAsJsonAsync("api/reservas", request);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<int>();
        }

        public async Task<ReservaParaImprimir?> GetReservaParaImprimirAsync(int nroReserva)
        {
            var response = await _httpClient.GetAsync($"api/reservas/{nroReserva}/impresion");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<ReservaParaImprimir>();
            }
            return null;
        }

        public async Task<bool> YaFueEntregadoAsync(int nroReserva)
        {
            var response = await _httpClient.GetFromJsonAsync<bool>($"api/reservas/{nroReserva}/fueentregado");
            return response;
        }
    }
}
