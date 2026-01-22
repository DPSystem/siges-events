using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class ActaInspector
{
    public int Id { get; set; }

    public int? IdactaInspector { get; set; }

    public int? Acta { get; set; }

    public int? Inspector { get; set; }
}
