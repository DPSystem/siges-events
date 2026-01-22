using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class DetalleCanje
{
    public int Id { get; set; }

    public int? IdCanje { get; set; }

    public int? Cantidad { get; set; }

    public string? Descripcion { get; set; }
}
