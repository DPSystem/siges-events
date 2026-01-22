using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models
{
    public class ReservaParaImprimir
    {
        public string NroReserva { get; set; }
        public int NroSocio { get; set; }
        public string ApellidoNombreSocio { get; set; }
        public double dni { get; set; }
        public List<string> Familiares { get; set; }
        public List<string> Regalos { get; set; }
    }
}