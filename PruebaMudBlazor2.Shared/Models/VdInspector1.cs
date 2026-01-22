using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class VdInspector1
{
    public int Id { get; set; }

    public int InspectorId { get; set; }

    public int EmpresaId { get; set; }

    public string? Cuit { get; set; }

    public DateTime FechaAsignacion { get; set; }

    public int Estado { get; set; }

    public DateTime? FechaCierre { get; set; }

    public DateTime? Desde { get; set; }

    public DateTime? Hasta { get; set; }

    public DateTime? FechaVenc { get; set; }

    public int? TipoInteres { get; set; }

    public decimal? InteresMensual { get; set; }

    public decimal? InteresDiario { get; set; }

    public decimal? Capital { get; set; }

    public decimal? Interes { get; set; }

    public decimal? Total { get; set; }

    public int? EmpleadosCantidad { get; set; }

    public int? UserId { get; set; }
}
