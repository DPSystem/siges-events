using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Tarjeta
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? NombreReducido { get; set; }
}
