using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class EquipoEscudo
{
    public int Id { get; set; }

    public int? TorneoId { get; set; }

    public int? EquipoId { get; set; }

    public byte[]? Imagen { get; set; }
}
