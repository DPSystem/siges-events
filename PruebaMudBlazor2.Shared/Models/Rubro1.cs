using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Rubro1
{
    public int Id { get; set; }

    public int? UsuarioId { get; set; }

    public string? Nombre { get; set; }

    public DateTime? FechaCarga { get; set; }

    public int? Estado { get; set; }

    public DateTime? FechaBaja { get; set; }
}
