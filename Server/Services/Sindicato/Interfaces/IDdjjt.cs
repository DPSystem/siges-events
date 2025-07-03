using Shared.Models.Sindicato;

namespace Server.Services.Sindicato.Interfaces
{
    public interface IDdjjt
    {
        Task<Ddjjt> GetByDni(int id);
    }
}
