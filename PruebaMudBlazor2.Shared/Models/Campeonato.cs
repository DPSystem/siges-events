using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Campeonato
{
    public int Campid { get; set; }

    public int CampLigaid { get; set; }

    public string Campnombre { get; set; } = null!;

    public string Camptemporada { get; set; } = null!;

    public int Campaño { get; set; }

    public int Campestado { get; set; }
}
