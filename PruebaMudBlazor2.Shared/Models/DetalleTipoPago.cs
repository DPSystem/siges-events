using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class DetalleTipoPago
{
    public int Id { get; set; }

    public int? IdCobroDetalle { get; set; }

    public string? NroCehque { get; set; }

    public decimal? Importe { get; set; }

    public DateTime? FechaVenc { get; set; }

    /// <summary>
    /// 0 - En espera  / 1 - Cobrado / 2 - Rechazado
    /// </summary>
    public int? Estado { get; set; }
}
