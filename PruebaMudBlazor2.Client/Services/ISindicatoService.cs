using PruebaMudBlazor2.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PruebaMudBlazor2.Client.Services
{
    public interface ISindicatoService
    {
        Task<int> SetReservaMochila(string cuil, string celular, int estado);
        Task<bool> SetAlumnoMochila(List<Alumno> alumnos, int nroReserva);
        Task<EventosCupone> GetReservaPorCupon(int nroCupon);
        Task<Maesoc> GetSocioPorCuil(double cuil);
        Task<List<EventosCupone>> GetReservasPendientes();
        Task<bool> YaFueEntregado(int nroReserva);
        Task<ReservaParaImprimir> GetReservaImpresion(int nroReserva);
    }
}