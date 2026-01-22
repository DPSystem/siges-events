using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Servicio
{
    public int IdServicio { get; set; }

    public string? NombreServicio { get; set; }

    public decimal? PrecioServicio { get; set; }

    public DateTime? FechaCarga { get; set; }
}
