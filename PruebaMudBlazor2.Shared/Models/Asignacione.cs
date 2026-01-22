using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Asignacione
{
    public int Id { get; set; }

    public DateTime? Fecha { get; set; }

    public int? Numero { get; set; }

    public int? CobradorId { get; set; }
}
