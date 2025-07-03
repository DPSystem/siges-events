using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shared.Models.Sindicato;

namespace Server.Services.Sindicato.Interfaces
{
    public interface ISoccenService
    {
        Task<IEnumerable<Soccen>> GetAllAsync();
        Task<Soccen> GetByIdAsync(int id);
        Task<Soccen> AddAsync(Soccen soccen);
        Task<Soccen> UpdateAsync(Soccen soccen);
        Task DeleteAsync(int id);
        Task<Soccen> GetSocioByCuil(double cuil);
    }
}
