using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class EstudioContableEmpresa
{
    public int Id { get; set; }

    public int? EstudioContableId { get; set; }

    public string? Cuit { get; set; }
}
