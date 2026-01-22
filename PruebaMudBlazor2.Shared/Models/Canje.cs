using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Canje
{
    public int Id { get; set; }

    public int? NroDeActa { get; set; }

    public int? NroDeRecibo { get; set; }

    public DateTime? FechaRemito { get; set; }

    public DateTime? FechaFactura { get; set; }

    public decimal? ImporteFactura { get; set; }

    public string? Descripcion { get; set; }

    public int? UsuarioId { get; set; }
}
