using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class ImpresionActa
{
    public int IdImpresionActas { get; set; }

    public string? Acta { get; set; }

    public decimal? Importe { get; set; }

    public string? Desde { get; set; }

    public string? Hasta { get; set; }

    public string? Inspector { get; set; }

    public string? Cobrado { get; set; }

    public DateTime? Fecha1 { get; set; }

    public DateTime? Fecha2 { get; set; }

    public DateTime? Fecha3 { get; set; }

    public decimal? Num1 { get; set; }

    public decimal? Num2 { get; set; }

    public decimal? Num3 { get; set; }
}
