using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class TipoDePago
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public int? Estado { get; set; }

    public string? Concepto { get; set; }
}
