using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Control
{
    public int IdControls { get; set; }

    public string Nombre { get; set; } = null!;

    public int Estado { get; set; }
}
