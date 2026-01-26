using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using PruebaMudBlazor2.Client.DTOs;
using System.Text.Json;

namespace PruebaMudBlazor2.Client.Services
{
    public class AuthService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        private readonly string _authApiUrl;

        public AuthService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _authApiUrl = _configuration.GetSection("ApiConfiguration:AuthApiUrl").Value + "api/Auth/login"; // Assuming login endpoint
            _httpClient.BaseAddress = new System.Uri(_authApiUrl); // Set BaseAddress for this client
        }

        public async Task<LoginResponse> Login(LoginRequest loginRequest)
        {
            var result = await _httpClient.PostAsJsonAsync(_authApiUrl, loginRequest);
            
            if (result.IsSuccessStatusCode)
            {
                var content = await result.Content.ReadAsStringAsync();
                var loginResponse = JsonSerializer.Deserialize<LoginResponse>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                loginResponse.IsAuthSuccessful = true;
                return loginResponse;
            }
            else
            {
                var errorContent = await result.Content.ReadAsStringAsync();
                return new LoginResponse { IsAuthSuccessful = false, ErrorMessage = $"Login failed: {result.ReasonPhrase} - {errorContent}" };
            }
        }
    }
}
