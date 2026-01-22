using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Sancione
{
    public int Id { get; set; }

    public int JugadorId { get; set; }

    public int CantidadFechas { get; set; }

    public int? PartidoId { get; set; }

    public int FechaNro { get; set; }

    public int? TarjetaId { get; set; }

    public string? TarjetaNombre { get; set; }

    public DateTime FechaDesde { get; set; }

    public DateTime FechaHasta { get; set; }

    public DateTime FechaPartido { get; set; }

    public string? ApeNom { get; set; }

    public string? Equipo { get; set; }

    public int? GrupoId { get; set; }

    public int? CategoriaId { get; set; }
}
