using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Quincho
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Turno { get; set; } = null!;

    public int Estado { get; set; }

    public int? Capacidad { get; set; }

    public decimal? Costo { get; set; }

    public decimal? SeguroVajilla { get; set; }

    public decimal? Limpieza { get; set; }
}
