using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Aviso
{
    public int IdAviso { get; set; }

    public int NroAviso { get; set; }

    public int? IdActa { get; set; }

    public DateTime? FechaGenAviso { get; set; }
}
