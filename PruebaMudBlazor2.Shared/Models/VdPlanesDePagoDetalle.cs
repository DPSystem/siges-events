using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class VdPlanesDePagoDetalle
{
    public int Id { get; set; }

    public int? PlanesDePagoId { get; set; }

    public int? NroPlanDePago { get; set; }

    public int? Cuota { get; set; }

    public decimal? ImporteCuota { get; set; }

    public decimal? Interes { get; set; }

    public decimal? Amortizado { get; set; }

    public decimal? Aamortizar { get; set; }

    public DateTime? FechaVenc { get; set; }

    public int? Estado { get; set; }

    public decimal? InteresResarcitorio { get; set; }

    public int? DiasDeMora { get; set; }

    public decimal? ImporteCobrado { get; set; }

    public string? Cancelado { get; set; }

    public DateTime? FechaCancela { get; set; }
}
