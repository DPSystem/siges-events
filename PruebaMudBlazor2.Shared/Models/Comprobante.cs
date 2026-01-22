using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Comprobante
{
    public int ComprobanteId { get; set; }

    public string? Nombre { get; set; }

    public int? Estado { get; set; }

    public int? Numero { get; set; }

    public decimal? Importe { get; set; }
}
