using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Juece
{
    public int Juezid { get; set; }

    public string Juezapellido { get; set; } = null!;

    public string Jueznombre { get; set; } = null!;

    public string Juezdni { get; set; } = null!;

    public string? Jueztelefono { get; set; }
}
