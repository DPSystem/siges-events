using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using PruebaMudBlazor2.Client;
using PruebaMudBlazor2.Client.Services;
using System.Net.Http;
using System;
using Blazored.LocalStorage; // Added
using Microsoft.AspNetCore.Components.Authorization; // Added
using PruebaMudBlazor2.Client.Auth; // Added
using System.IdentityModel.Tokens.Jwt; // Added
using Microsoft.Extensions.Configuration; // Added for IConfiguration

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// --- HTTP CLIENT CONFIGURATION ---

// Get API URLs from configuration
var apiBaseUrl = builder.Configuration
    .GetSection("ApiConfiguration:BaseUrl")
    .Value ??
    throw new InvalidOperationException("ApiConfiguration:BaseUrl no se encontró en la configuración.");

var authApiUrl = builder.Configuration
    .GetSection("ApiConfiguration:AuthApiUrl")
    .Value ??
    throw new InvalidOperationException("ApiConfiguration:AuthApiUrl no se encontró en la configuración.");

// Register BearerTokenHandler for injecting token into API requests
builder.Services.AddScoped<BearerTokenHandler>();

// Register HttpClients
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(apiBaseUrl) });
builder.Services.AddHttpClient("ApiHttpClient", client =>
    {
        client.BaseAddress = new Uri(apiBaseUrl);
    })
    .AddHttpMessageHandler<BearerTokenHandler>(); // Use the BearerTokenHandler

builder.Services.AddHttpClient("AuthApiClient", client =>
{
    client.BaseAddress = new Uri(authApiUrl);
});


// --- AUTHENTICATION SERVICES REGISTRATION ---

builder.Services.AddBlazoredLocalStorage(); // Service to handle local storage
builder.Services.AddAuthorizationCore(); // Core authorization services
builder.Services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>(); // Custom Authentication State Provider
builder.Services.AddScoped<AuthService>(); // Custom Authentication Service


// --- OTHER SERVICES REGISTRATION ---

// Register services that depend on named HttpClients
builder.Services.AddScoped<ISociosApiClient, SociosApiClient>(sp =>
    new SociosApiClient(sp.GetRequiredService<IHttpClientFactory>().CreateClient("ApiHttpClient")));
builder.Services.AddScoped<IReservasApiClient, ReservasApiClient>(sp =>
    new ReservasApiClient(sp.GetRequiredService<IHttpClientFactory>().CreateClient("ApiHttpClient")));
builder.Services.AddScoped<IAlumnosApiClient, AlumnosApiClient>(sp =>
    new AlumnosApiClient(sp.GetRequiredService<IHttpClientFactory>().CreateClient("ApiHttpClient")));
builder.Services.AddScoped<ISindicatoService, SindicatoService>(sp =>
    new SindicatoService(sp.GetRequiredService<IHttpClientFactory>().CreateClient("ApiHttpClient")));
builder.Services.AddScoped<IEventosApiClient, EventosApiClient>(sp =>
    new EventosApiClient(sp.GetRequiredService<IHttpClientFactory>().CreateClient("ApiHttpClient")));


// Register services of MudBlazor
builder.Services.AddMudServices();

// Prevent mapping of inbound claims
JwtSecurityTokenHandler.DefaultMapInboundClaims = false;

await builder.Build().RunAsync();
