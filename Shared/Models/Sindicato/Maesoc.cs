using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shared.Models.Sindicato
{
    public class Maesoc
    {
        public double MAESOC_CUIL { get; set; }
        public string MAESOC_APELLIDO { get; set; } = String.Empty;
        public string MAESOC_NOMBRE { get; set; } = String.Empty;
        public string MAESOC_TEL { get; set; } = String.Empty;
        public string MAESOC_TELCEL { get; set; } = String.Empty;
        public DateTime MAESOC_FECHANAC { get; set; }
        public short MAESOC_CARGAFLIA { get; set; }
        public int MAESOC_JUBIL { get; set; }
        public byte MAESOC_PREDOC { get; set; }
        public DateTime MAESOC_FECHADOC { get; set; }
        public short MAESOC_CODCAT { get; set; }
        public short MAESOC_CODACT { get; set; }
        public int MAESOC_TIPODOC { get; set; }
        public string MAESOC_NRODOC { get; set; } = String.Empty;
        public int MAESOC_GRUPOSANG { get; set; }
        public string MAESOC_SEXO { get; set; } = String.Empty;
        public string MAESOC_ESTCIV { get; set; } = String.Empty;
        public string MAESOC_CODPROV { get; set; } = String.Empty;
        public int MAESOC_CODLOC { get; set; }
        public string MAESOC_CODPOS { get; set; } = String.Empty;
        public string MAESOC_BARRIO { get; set; } = String.Empty;
        public string MAESOC_NACIONALIDAD { get; set; } = String.Empty;
        public string MAESOC_CALLE { get; set; } = String.Empty;
        public string MAESOC_NROCALLE { get; set; } = String.Empty;
        public string MAESOC_PISO { get; set; } = String.Empty;
        public string MAESOC_DTO { get; set; } = String.Empty;
        public int MAESOC_CODOSM { get; set; }
        public int MAESOC_CODCON { get; set; }
        public string MAESOC_NROAFIL { get; set; } = String.Empty;
        public string MAESOC_EMAIL { get; set; } = String.Empty;
        public string MAESOC_EMAILLAB { get; set; } = String.Empty;
        public string MAESOC_NROCARNET { get; set; } = String.Empty;
        public string MAESOC_IMPEST1 { get; set; } = String.Empty;
        public string MAESOC_IMPEST2 { get; set; } = String.Empty;
        public string MAESOC_IMPEST3 { get; set; } = String.Empty;
        public string MAESOC_IMPEST4 { get; set; } = String.Empty;
        public string MAESOC_IMPEST5 { get; set; } = String.Empty;
        public string MAESOC_IMPEST6 { get; set; } = String.Empty;
        public string MAESOC_DEBAUT_CBU { get; set; } = String.Empty;
        public double MAESOC_DEBAUT_MONTO { get; set; }
        public byte MAESOC_ACTUALIZA { get; set; }
        public int MAESOC_DTOFARMACIA { get; set; }
        public int MAESOC_ESTADO { get; set; }
        public DateTime MAESOC_FECHAALTA { get; set; }
        public DateTime MAESOC_FECHAMOD { get; set; }
        public DateTime MAESOC_FECHADESEMPLEO { get; set; }
        public string MAESOC_USUMOD { get; set; } = String.Empty;
        public string APENOM { get; set; } = String.Empty;
        public string MAESOC_CUIL_STR { get; set; } = String.Empty;
    }
}
