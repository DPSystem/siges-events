using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class JugadoresExepcione
{
    public int Id { get; set; }

    public string Apellido { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public int Dni { get; set; }

    public long Cuil { get; set; }

    public int EquipoId { get; set; }

    public int CategoriaId { get; set; }

    public int Tipo { get; set; }
}
