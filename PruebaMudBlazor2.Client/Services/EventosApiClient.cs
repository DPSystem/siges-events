using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using PruebaMudBlazor2.Shared.Models;

namespace PruebaMudBlazor2.Client.Services
{
    public class EventosApiClient : IEventosApiClient
    {
        private readonly HttpClient _httpClient;

        public EventosApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Evento>> GetEventos()
        {
            return await _httpClient.GetFromJsonAsync<List<Evento>>("api/Eventos");
        }

        public async Task<EventosAño> CreateEventoAño(EventosAño eventoAño)
        {
            var response = await _httpClient.PostAsJsonAsync("api/EventosAño", eventoAño);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<EventosAño>();
        }

        public async Task<List<EventosAño>> GetEventosAñoByEventoId(int eventoId)
        {
            return await _httpClient.GetFromJsonAsync<List<EventosAño>>($"api/EventosAño/byevento/{eventoId}");
        }

        public async Task<List<EventosAño>> GetEventosAñoFiltered(int eventoId, int estado)
        {
            return await _httpClient.GetFromJsonAsync<List<EventosAño>>($"api/EventosAño/filtered/{eventoId}/{estado}");
        }
    }
}
