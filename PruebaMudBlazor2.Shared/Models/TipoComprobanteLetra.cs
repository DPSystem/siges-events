using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class TipoComprobanteLetra
{
    public int Id { get; set; }

    public string? Letra { get; set; }

    public DateTime? FechaAlta { get; set; }

    public int? Estado { get; set; }

    public int? UsuarioId { get; set; }
}
