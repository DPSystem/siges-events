using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Inspectore
{
    public int IdInspector { get; set; }

    public string? Apellido { get; set; }

    public string? Nombre { get; set; }

    public string? Telefono { get; set; }

    public int? Estudio { get; set; }
}
