using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Cobradore
{
    public int Id { get; set; }

    public string Apellido { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Dni { get; set; } = null!;

    public int Estado { get; set; }
}
