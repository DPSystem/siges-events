using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class AsignarCobranza
{
    public int Id { get; set; }

    public DateTime? Fecha { get; set; }

    public int CobradorId { get; set; }

    public string Cuit { get; set; } = null!;

    public int Acta { get; set; }

    public int Estado { get; set; }

    public int NroAsignacion { get; set; }

    public int? ActaId { get; set; }
}
