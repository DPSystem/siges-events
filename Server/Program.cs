using Data;
using Microsoft.EntityFrameworkCore;
using Server.Services.Sindicato.Implements;
using Server.Services.Sindicato.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var sindicatoDbConnection = builder.Configuration["ConnectionStrings:SindicatoDB"];
builder.Services.AddDbContext<SindicatoDBcontext>(options =>
    options.UseSqlServer(sindicatoDbConnection)
);

builder.Services.AddScoped<ISoccenService, SoccenService>();
builder.Services.AddScoped<IMaesocService, MaesocService>();
builder.Services.AddScoped<IDdjjService, DdjjService>();

builder.Services.AddControllers();

// Configurar Kestrel para soportar HTTPS
builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(5285); // HTTP
    options.ListenAnyIP(
        7117,
        listenOptions =>
        {
            listenOptions.UseHttps(); // HTTPS
        }
    );
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
