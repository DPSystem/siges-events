using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Deposito
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Ubicacion { get; set; }

    public int? Estado { get; set; }
}
