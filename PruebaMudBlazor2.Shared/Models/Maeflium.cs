using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Maeflium
{
    public long MaefliaCodfliar { get; set; }

    public long MaefliaNrodoc { get; set; }

    public int MaefliaTipodoc { get; set; }

    public string MaefliaApellido { get; set; } = null!;

    public string MaefliaNombre { get; set; } = null!;

    public DateTime MaefliaFecnac { get; set; }

    public DateTime MaefliaFecing { get; set; }

    public int MaefliaGrusan { get; set; }

    public string MaefliaNrocarnet { get; set; } = null!;

    public byte MaefliaRecfar { get; set; }

    public byte MaefliaReccen { get; set; }

    public byte MaefliaRecfoc { get; set; }

    public byte MaefliaRecfam { get; set; }

    public byte MaefliaRecbib { get; set; }

    public string MaefliaSexo { get; set; } = null!;

    public string MaefliaEstcivil { get; set; } = null!;

    public byte MaefliaDiscapac { get; set; }

    public byte MaefliaEstudia { get; set; }

    public string MaefliaEstablec { get; set; } = null!;

    public string MaefliaAñoestablec { get; set; } = null!;

    public string MaefliaTalle { get; set; } = null!;
}
