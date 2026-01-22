using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class VdPlanesDePago
{
    public int Id { get; set; }

    public DateTime? Fecha { get; set; }

    public int? Numero { get; set; }

    public decimal? Deuda { get; set; }

    public decimal? Ajuste { get; set; }

    public decimal DeudaConAjuste { get; set; }

    public decimal InteresFinanciacionPorcentaje { get; set; }

    public decimal InteresFinanciacionImporte { get; set; }

    public decimal? DeudaConInteres { get; set; }

    public decimal? Anticipo { get; set; }

    public DateTime? AnticipoVencimiento { get; set; }

    public decimal? DeudaAfinanciar { get; set; }

    public int? Cuotas { get; set; }

    public decimal? CuotasImporte { get; set; }

    public DateTime? CuotaVencimiento { get; set; }

    public string? Comentario { get; set; }

    public int? NumeroVd { get; set; }

    public int? ActaId { get; set; }

    public int? Acta { get; set; }

    public int? UserId { get; set; }
}
