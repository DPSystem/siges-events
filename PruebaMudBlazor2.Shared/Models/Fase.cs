using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Fase
{
    public int FaseId { get; set; }

    public string Fasenombre { get; set; } = null!;

    public string? Fasedescripcion { get; set; }
}
