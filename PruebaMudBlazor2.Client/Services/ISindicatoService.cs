using PruebaMudBlazor2.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PruebaMudBlazor2.Client.Services
{
    public interface ISindicatoService
    {
        Task<int> SetReservaMochila(string cuil, string celular, int estado, int eventosAñoId);
        Task<bool> SetAlumnoMochila(List<Alumno> alumnos, int nroReserva, int eventosAñoId);
        Task<EventosCupone> GetReservaPorCupon(int nroCupon, int eventosAñoId);
        Task<Maesoc> GetSocioPorCuil(double cuil);
        Task<List<EventosCupone>> GetReservasPendientes();
        Task<bool> YaFueEntregado(int nroReserva, int eventosAñoId);
        Task<ReservaParaImprimir> GetReservaImpresion(int nroReserva, int eventosAñoId);
    }
}