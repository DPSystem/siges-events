using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Cobro
{
    public DateTime? Mes { get; set; }

    public string? Inspector { get; set; }

    public DateTime? Fecharecaudacion { get; set; }

    public double? Acta { get; set; }

    public string? Empresa { get; set; }

    public double? Cuit { get; set; }

    public double? Recibo { get; set; }

    public double? Cheque { get; set; }

    public double? Importecheque { get; set; }

    public string? Desconocido { get; set; }

    public string? Cuotas { get; set; }

    public double? Importe { get; set; }

    public double? Mercaderias { get; set; }

    public double? Importemercaderia { get; set; }

    public double? Total { get; set; }

    public string? Concepto { get; set; }

    public string? Interes { get; set; }

    public string? DiasAtraso { get; set; }

    public string? FechaVenc { get; set; }

    public string? Cuotax { get; set; }

    public string? CantidadCuotas { get; set; }

    public int Id { get; set; }
}
