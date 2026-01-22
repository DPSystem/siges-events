using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class ArticulosPrecio
{
    public int Id { get; set; }

    public int? ArticuloId { get; set; }

    public int? ArticulosMovsId { get; set; }

    public int? ArticulosMovsNumero { get; set; }

    public decimal? PrecioVenta { get; set; }

    public DateTime? Fecha { get; set; }

    public int? UsuarioId { get; set; }

    public decimal? PrecioCosto { get; set; }
}
