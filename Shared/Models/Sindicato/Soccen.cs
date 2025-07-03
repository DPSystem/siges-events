using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shared.Models.Sindicato
{
    public class Soccen
    {
        public double SOCCEN_CUIL { get; set; }
        public byte SOCCEN_ESTADO { get; set; }
        public int SOCCEN_CODIVA { get; set; }
        public DateTime SOCCEN_FEING { get; set; }
        public DateTime SOCCEN_FEBAJA { get; set; }
        public int SOCCEN_NRORESCOMDIR { get; set; }
        public long SOCCEN_CREDMAX { get; set; }
        public string SOCCEN_CONDCRED { get; set; } = String.Empty;
        public byte SOCCEN_SOCDIR { get; set; }
        public byte SOCCEN_DESPEDIDO { get; set; }
        public byte SOCCEN_ACTUALIZA { get; set; }
    }
}
