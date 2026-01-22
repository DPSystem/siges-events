using PruebaMudBlazor2.Shared.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace PruebaMudBlazor2.Client.Services
{
    public class SociosApiClient : ISociosApiClient
    {
        private readonly HttpClient _httpClient;

        public SociosApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Maesoc?> GetSocioByDniAsync(string dni)
        {
            var response = await _httpClient.GetAsync($"api/socios/{dni}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Maesoc>();
            }
            return null;
        }

        public async Task<bool> EsSocioActivoAsync(string dni)
        {
            var response = await _httpClient.GetFromJsonAsync<bool>($"api/socios/{dni}/essocio");
            return response;
        }

        public async Task<Foto?> GetFotoTitularAsync(double cuil)
        {
            var response = await _httpClient.GetAsync($"api/socios/{cuil}/foto");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Foto>();
            }
            return null;
        }

        public async Task<bool> GetCarenciaAsync(double cuil)
        {
            var response = await _httpClient.GetFromJsonAsync<bool>($"api/socios/{cuil}/carencia");
            return response;
        }

        public async Task<bool> CumpleConAporteMinimoAsync(double cuil)
        {
            var response = await _httpClient.GetFromJsonAsync<bool>($"api/socios/{cuil}/aporteminimo");
            return response;
        }
    }
}
