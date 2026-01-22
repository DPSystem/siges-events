using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class JugadorTarjetum
{
    public int Id { get; set; }

    public int? JugadorId { get; set; }

    public int? TarjetaId { get; set; }

    public int? Cumplida { get; set; }

    public int? AutoGenerada { get; set; }

    public int? PartidoId { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public int? UsuarioId { get; set; }
}
