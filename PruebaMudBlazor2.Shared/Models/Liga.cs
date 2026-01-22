using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Liga
{
    public int Ligaid { get; set; }

    public string Liganombre { get; set; } = null!;

    public int Ligaestado { get; set; }
}
