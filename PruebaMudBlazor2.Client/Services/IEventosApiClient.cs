using PruebaMudBlazor2.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PruebaMudBlazor2.Client.Services
{
    public interface IEventosApiClient
    {
        Task<List<Evento>> GetEventos();
        Task<EventosAño> CreateEventoAño(EventosAño eventoAño);
        Task<List<EventosAño>> GetEventosAñoByEventoId(int eventoId);
        Task<List<EventosAño>> GetEventosAñoFiltered(int eventoId, int estado);
    }
}
