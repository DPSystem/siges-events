using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Comentario
{
    public int Id { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Comentario1 { get; set; }

    public int? PiId { get; set; }

    public int? PcId { get; set; }
}
