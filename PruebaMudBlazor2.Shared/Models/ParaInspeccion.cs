using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class ParaInspeccion
{
    public int Id { get; set; }

    public string Cuil { get; set; } = null!;

    public string Cuit { get; set; } = null!;

    public int Estado { get; set; }

    public DateTime? Fecha { get; set; }
}
