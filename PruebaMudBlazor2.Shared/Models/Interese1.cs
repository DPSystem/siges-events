using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Interese1
{
    public int Id { get; set; }

    public DateTime? Desde { get; set; }

    public DateTime? Hasta { get; set; }

    public string? Norma { get; set; }

    public int? TipoDeInteres { get; set; }

    public decimal? Mensual { get; set; }

    public decimal? Diario { get; set; }
}
