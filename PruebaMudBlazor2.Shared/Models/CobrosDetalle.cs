using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class CobrosDetalle
{
    public int Id { get; set; }

    public int? CobrosId { get; set; }

    public int? Efectivo { get; set; }

    public int? TipoDePagoId { get; set; }

    public DateTime? Fecha { get; set; }

    public int? Recibo { get; set; }

    public decimal? Importe { get; set; }

    public int? UsuarioId { get; set; }

    /// <summary>
    /// 1 -Efectivo / 2 - Cheque  / 3 - Canje
    /// </summary>
    public int? Estado { get; set; }
}
