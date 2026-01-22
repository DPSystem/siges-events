using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class EventosExep
{
    public int EventExepId { get; set; }

    public string EventExepApellido { get; set; } = null!;

    public string EventExepNombre { get; set; } = null!;

    public string EventExepDni { get; set; } = null!;

    public int EventExepParent { get; set; }

    public double EventExepSocioCuil { get; set; }

    public DateTime? EventExepFechanac { get; set; }

    public string? EventExepSexo { get; set; }
}
