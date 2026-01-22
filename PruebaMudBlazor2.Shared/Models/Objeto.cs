using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Objeto
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public int? Estado { get; set; }

    public int? RolId { get; set; }

    public int? ModuloId { get; set; }
}
