using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Partido
{
    public int Partidoid { get; set; }

    public int PartidoCampid { get; set; }

    public int Partidoequipo1 { get; set; }

    public int Partidoequipo2 { get; set; }

    public DateOnly Partidofecha { get; set; }

    public TimeOnly Partidohora { get; set; }

    public int PartidoCanchaid { get; set; }

    public int Partidoequipo1goles { get; set; }

    public int Partidoequipo2goles { get; set; }

    public int PartidoFaseid { get; set; }

    public int PartidoLigaid { get; set; }

    public int PartidoCatid { get; set; }

    public int? PartidoGrupoid { get; set; }

    public int? Partidonrofecha { get; set; }

    public bool? GolesCargados { get; set; }

    public bool? SancionesCargadas { get; set; }

    public int? Equipo1GrupoId { get; set; }

    public int? Equipo2GrupoId { get; set; }

    public bool? ResultadosCargados { get; set; }
}
