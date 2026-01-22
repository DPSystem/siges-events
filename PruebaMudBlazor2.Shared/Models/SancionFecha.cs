using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class SancionFecha
{
    public int Id { get; set; }

    public int? SancionId { get; set; }

    public int? JugId { get; set; }

    public int? FechaAcumplir { get; set; }

    public string? De { get; set; }

    public int? TotalDeFechas { get; set; }

    public int? CumpleEn { get; set; }

    public int? Cumplida { get; set; }

    public int? GrupoId { get; set; }

    public int? CategoriaId { get; set; }
}
