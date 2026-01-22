using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class EventosArtAsig
{
    public int Id { get; set; }

    public int? EventoArticuloId { get; set; }

    public string? EventoCuponId { get; set; }

    public int? Estado { get; set; }
}
