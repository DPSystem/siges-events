using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class ActasCruzar
{
    public DateTime? Fecha { get; set; }

    public double? NroActa { get; set; }

    public string? Empresa { get; set; }

    public double? Cuit { get; set; }

    public string? Domicilio { get; set; }

    public DateTime? Desde { get; set; }

    public DateTime? Hasta { get; set; }

    public double? DeudaHistorica { get; set; }

    public double? Intereses { get; set; }

    public double? DeudaActualizada { get; set; }

    public double? InteresesDeFinanciacion { get; set; }

    public double? DeudaTotal { get; set; }

    public string? CobradoTotalmente { get; set; }

    public string? Inspector { get; set; }

    public string? Observaciones { get; set; }
}
