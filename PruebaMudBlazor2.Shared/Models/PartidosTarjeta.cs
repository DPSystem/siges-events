using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class PartidosTarjeta
{
    public int Partitarjid { get; set; }

    public int PartitarjPartidoid { get; set; }

    public int PartitarjTarjetaid { get; set; }

    public int PartitarjJugid { get; set; }

    public string Partitarjtiempo { get; set; } = null!;

    public string Partitarjminuto { get; set; } = null!;

    public string Partitarjmotivo { get; set; } = null!;
}
