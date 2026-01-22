using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class VentasDetalle
{
    public int Id { get; set; }

    public int? VentaId { get; set; }

    public int? NroDeCaja { get; set; }

    public int? ArticuloId { get; set; }

    public string? CodeBar { get; set; }

    public int? Codigo { get; set; }

    public decimal? PrecioU { get; set; }

    public int? Cantidad { get; set; }

    public decimal? Total { get; set; }
}
