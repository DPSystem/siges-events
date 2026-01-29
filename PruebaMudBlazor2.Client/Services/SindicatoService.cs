using PruebaMudBlazor2.Shared;
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

        public async Task<int> SetReservaMochila(string cuil, string celular, int estado, int eventosAñoId)
        {
            var response = await _httpClient.PostAsJsonAsync("api/reservas", new ReservaRequest { CuilTitular = cuil, NroDeCelular = celular, Estado = estado, EventosAñoId = eventosAñoId });
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<int>();
        }

        public async Task<bool> SetAlumnoMochila(List<Alumno> alumnos, int nroReserva, int eventosAñoId)
        {
            var request = new AsignacionMochilaRequest
            {
                Alumnos = alumnos,
                NroDeReserva = nroReserva,
                EventosAñoId = eventosAñoId
            };
            var response = await _httpClient.PostAsJsonAsync("api/alumnos/mochilas", request);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<bool>();
        }

        public async Task<EventosCupone> GetReservaPorCupon(int nroCupon, int eventosAñoId)
        {
            return await _httpClient.GetFromJsonAsync<EventosCupone>($"api/reservas/{nroCupon}/{eventosAñoId}");
        }

        public async Task<Maesoc> GetSocioPorCuil(double cuil)
        {
            return await _httpClient.GetFromJsonAsync<Maesoc>($"api/socios/cuil/{cuil}");
        }

        public async Task<List<EventosCupone>> GetReservasPendientes()
        {
            return await _httpClient.GetFromJsonAsync<List<EventosCupone>>("api/reservas/pendientes");
        }

        public async Task<bool> YaFueEntregado(int nroReserva, int eventosAñoId)
        {
            return await _httpClient.GetFromJsonAsync<bool>($"api/reservas/{nroReserva}/fueentregado/{eventosAñoId}");
        }

        public async Task<ReservaParaImprimir> GetReservaImpresion(int nroReserva, int eventosAñoId)
        {
            return await _httpClient.GetFromJsonAsync<ReservaParaImprimir>($"api/reservas/{nroReserva}/impresion/{eventosAñoId}");
        }
    }
}
