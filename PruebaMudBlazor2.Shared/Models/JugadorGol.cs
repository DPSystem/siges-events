using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class JugadorGol
{
    public int Id { get; set; }

    public int? JugadorId { get; set; }

    public int? PartidoId { get; set; }

    public int? GrupoId { get; set; }

    public int? CategId { get; set; }

    public int? Fecha { get; set; }

    public int? Goles { get; set; }

    public DateTime? CreateDatetime { get; set; }

    public int? UsuarioId { get; set; }

    public string? ApeNom { get; set; }

    public string? Equipo { get; set; }
}
