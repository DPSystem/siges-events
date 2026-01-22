using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class VdInspector
{
    public int Id { get; set; }

    public int? Numero { get; set; }

    public int InspectorId { get; set; }

    public int EmpresaId { get; set; }

    public string? Cuit { get; set; }

    public DateTime FechaAsignacion { get; set; }

    /// <summary>
    /// 0-VD / 1-Acta / 2-Cancel
    /// </summary>
    public int Estado { get; set; }

    public DateTime? FechaCierre { get; set; }

    public DateTime? Desde { get; set; }

    public DateTime? Hasta { get; set; }

    public DateTime? FechaVenc { get; set; }

    /// <summary>
    /// 0- Manual / 1-AFIP
    /// </summary>
    public int? TipoInteres { get; set; }

    public decimal? InteresMensual { get; set; }

    public decimal? InteresDiario { get; set; }

    public decimal? Capital { get; set; }

    public decimal? Interes { get; set; }

    public decimal? Total { get; set; }

    public int? EmpleadosCantidad { get; set; }

    public int? UserId { get; set; }

    public int? NroDeActa { get; set; }
}
