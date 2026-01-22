using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Categoria
{
    public int Catid { get; set; }

    public string Catnombre { get; set; } = null!;

    public int Catedadlimite { get; set; }

    public int Catestado { get; set; }
}
