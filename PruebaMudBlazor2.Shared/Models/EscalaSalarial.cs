using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class EscalaSalarial
{
    public int Id { get; set; }

    public DateTime? Periodo { get; set; }

    public int? CodCategoria { get; set; }

    public decimal? Importe { get; set; }

    public decimal? Acuerdo { get; set; }

    public int? Estado { get; set; }
}
