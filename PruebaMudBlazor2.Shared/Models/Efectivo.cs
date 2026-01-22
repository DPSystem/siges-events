using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Efectivo
{
    public int Id { get; set; }

    public int? NroDeRecibo { get; set; }

    public int? NroDeActa { get; set; }

    public decimal? Importe { get; set; }

    public DateTime? Fecha { get; set; }
}
