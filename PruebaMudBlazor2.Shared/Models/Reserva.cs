using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models
{
    public class Reserva
    {
        public string NroReserva { get; set; } = string.Empty;
        public string NroSocio { get; set; } = string.Empty;
        public string ApellidoNombreSocio { get; set; } = string.Empty;
        public string dni { get; set; } = string.Empty;
        public List<string> Familiares { get; set; } = new();
        public List<string> Regalos { get; set; } = new();
        public int idPrinter { get; set; }
    }
}
