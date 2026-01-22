using PruebaMudBlazor2.Shared.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace PruebaMudBlazor2.Client.Services
{
    public class SindicatoService : ISindicatoService
    {
        private readonly HttpClient _httpClient;

        public SindicatoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<int> SetReservaMochila(string cuil, string celular, int estado)
        {
            var response = await _httpClient.PostAsJsonAsync("api/sindicato/reserva-mochila", new { cuil, celular, estado });
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<int>();
        }

        public async Task<bool> SetAlumnoMochila(List<Alumno> alumnos, int nroReserva)
        {
            var response = await _httpClient.PostAsJsonAsync("api/sindicato/alumno-mochila", new { alumnos, nroReserva });
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<bool>();
        }

        public async Task<EventosCupone> GetReservaPorCupon(int nroCupon)
        {
            return await _httpClient.GetFromJsonAsync<EventosCupone>($"api/sindicato/reserva/{nroCupon}");
        }

        public async Task<Maesoc> GetSocioPorCuil(double cuil)
        {
            return await _httpClient.GetFromJsonAsync<Maesoc>($"api/sindicato/socio/{cuil}");
        }

        public async Task<List<EventosCupone>> GetReservasPendientes()
        {
            return await _httpClient.GetFromJsonAsync<List<EventosCupone>>("api/reservas/pendientes");
        }

        public async Task<bool> YaFueEntregado(int nroReserva)
        {
            return await _httpClient.GetFromJsonAsync<bool>($"api/reservas/{nroReserva}/fueentregado");
        }

        public async Task<ReservaParaImprimir> GetReservaImpresion(int nroReserva)
        {
            return await _httpClient.GetFromJsonAsync<ReservaParaImprimir>($"api/reservas/{nroReserva}/impresion");
        }
    }
}
