using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services; // Añadido para MudBlazor
using PruebaMudBlazor2.Client;
using PruebaMudBlazor2.Client.Services;
using System.Net.Http;
using System;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Configurar HttpClient base
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Registrar los clientes de API
builder.Services.AddHttpClient<ISociosApiClient, SociosApiClient>(client => client.BaseAddress = new Uri("https://localhost:7112"));
builder.Services.AddHttpClient<IReservasApiClient, ReservasApiClient>(client => client.BaseAddress = new Uri("https://localhost:7112"));
builder.Services.AddHttpClient<IAlumnosApiClient, AlumnosApiClient>(client => client.BaseAddress = new Uri("https://localhost:7112"));
builder.Services.AddHttpClient<ISindicatoService, SindicatoService>(client => client.BaseAddress = new Uri("https://localhost:7112"));

// Registrar servicios de MudBlazor
builder.Services.AddMudServices();

await builder.Build().RunAsync();
