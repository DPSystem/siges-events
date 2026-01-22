using PruebaMudBlazor2.Shared.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using PruebaMudBlazor2.Shared; // Para AsignacionMochilaRequest

namespace PruebaMudBlazor2.Client.Services
{
    public class AlumnosApiClient : IAlumnosApiClient
    {
        private readonly HttpClient _httpClient;

        public AlumnosApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Alumno>> GetAlumnosPorCuilAsync(double cuil)
        {
            return await _httpClient.GetFromJsonAsync<List<Alumno>>($"api/alumnos/{cuil}") ?? new List<Alumno>();
        }

        public async Task<bool> AsignarMochilasAsync(AsignacionMochilaRequest request)
        {
            var response = await _httpClient.PostAsJsonAsync("api/alumnos/mochilas", request);
            response.EnsureSuccessStatusCode();
            return response.IsSuccessStatusCode;
        }
    }
}
