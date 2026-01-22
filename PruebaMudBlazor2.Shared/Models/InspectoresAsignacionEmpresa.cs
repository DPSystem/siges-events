using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class InspectoresAsignacionEmpresa
{
    public int IdAsignacion { get; set; }

    public long CuitEmpresa { get; set; }

    public int IdInspector { get; set; }

    public DateTime FechaAsignacion { get; set; }

    public int? ActaGenerada { get; set; }

    public DateTime Desde { get; set; }

    public DateTime Hasta { get; set; }

    public decimal DeudaAproximada { get; set; }

    public DateTime? FechaGeneracionActa { get; set; }

    public DateTime? FechaEntregaAviso { get; set; }

    public int? NroAviso { get; set; }

    public int? Estado { get; set; }

    public int? Dias { get; set; }

    public decimal? DeudaDeterminada { get; set; }

    public DateOnly? PeriodoDesde { get; set; }

    public DateOnly? PeriodoHasta { get; set; }

    public decimal? Capital { get; set; }

    public decimal? IntResarc { get; set; }

    public int? Financiacion { get; set; }

    public decimal? Anticipo { get; set; }

    public decimal? Tasa { get; set; }

    public decimal? InteresFinanciacion { get; set; }

    public string? Coeficiente { get; set; }

    public int? Cuotas { get; set; }

    public decimal? ImporteCuota { get; set; }
}
