using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class PremiosSorteo
{
    public int Id { get; set; }

    public int? PremioId { get; set; }

    public string? PremioCodigo { get; set; }

    public int? SorteoId { get; set; }

    public int? SorteoNumero { get; set; }

    public int? Cantidad { get; set; }

    public int? Estado { get; set; }

    public DateTime? FechaCarga { get; set; }
}
