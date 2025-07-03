using Microsoft.AspNetCore.Mvc;
using Shared.Models.Sindicato;

namespace Server.Services.Sindicato.Interfaces
{
    public interface IDdjjService
    {
        Task<bool> GetCarenciaByCuil(string cuil, string fecha);
    }
}
