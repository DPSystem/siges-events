using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class ArticulosMov
{
    public int Id { get; set; }

    public int? ArticuloId { get; set; }

    public int? DepositoId { get; set; }

    public int? UsuarioId { get; set; }

    public int? ComprobanteId { get; set; }

    public int? TipoComprobanteLetraId { get; set; }

    public int? PuntoDeVenta { get; set; }

    public int? NumeroMovs { get; set; }

    public int? NumeroComprobante { get; set; }

    public decimal? Ingreso { get; set; }

    public decimal? Egreso { get; set; }

    public DateTime? Fecha { get; set; }

    public decimal? Cantidad { get; set; }

    public int? Codigo { get; set; }
}
