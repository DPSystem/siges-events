using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Grupo
{
    public int Id { get; set; }

    public string? Grupo1 { get; set; }

    public int? Estado { get; set; }

    public DateTime? FechaAlta { get; set; }

    public int? UsuarioId { get; set; }
}
