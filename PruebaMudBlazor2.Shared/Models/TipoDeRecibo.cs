using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class TipoDeRecibo
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public int? Estado { get; set; }
}
