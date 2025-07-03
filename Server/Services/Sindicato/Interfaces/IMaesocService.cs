using System.Collections.Generic;
using System.Threading.Tasks;
using Shared.Models.Sindicato;

namespace Server.Services.Sindicato.Interfaces
{
    public interface IMaesocService
    {
        Task<IEnumerable<Maesoc>> GetAllAsync();
        Task<Maesoc> GetByIdAsync(int id);
        Task<Maesoc> GetByDniAsync(string Dni);
        Task<Maesoc> AddAsync(Maesoc maesoc);
        Task<Maesoc> UpdateAsync(Maesoc maesoc);
        Task DeleteAsync(int id);
    }
}
