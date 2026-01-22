using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Sorteo
{
    public int Id { get; set; }

    public int? NumeroDeSorteo { get; set; }

    public string? Descripcion { get; set; }

    public int? EventoId { get; set; }

    public int? Estado { get; set; }
}
