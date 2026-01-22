using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class PlanesDePago
{
    public int Id { get; set; }

    public DateTime? Fecha { get; set; }

    public int NroDePlan { get; set; }

    public string Cuit { get; set; } = null!;

    public int NroDeAsignacion { get; set; }

    public int? Estado { get; set; }

    public decimal? DeudaInicial { get; set; }

    public int? ActaId { get; set; }

    public int? Acta { get; set; }

    public int? UserId { get; set; }
}
