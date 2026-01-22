using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Venta
{
    public int Id { get; set; }

    public DateTime? Fecha { get; set; }

    public int? NroDeCaja { get; set; }

    public decimal? Importe { get; set; }

    public int? UsuarioId { get; set; }

    public int? FormaDePago { get; set; }

    public decimal? PagoCon { get; set; }

    public decimal? Vuelto { get; set; }

    public int? CtaCte { get; set; }
}
