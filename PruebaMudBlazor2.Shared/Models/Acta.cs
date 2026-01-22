using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Acta
{
    public DateTime? Fecha { get; set; }

    public int? Acta1 { get; set; }

    public string? Empresa { get; set; }

    public double? Cuit { get; set; }

    public string? Domicilio { get; set; }

    public DateTime? Desde { get; set; }

    public DateTime? Hasta { get; set; }

    public double? Deudahistorica { get; set; }

    public double? Intereses { get; set; }

    public double? Deudaactualizada { get; set; }

    public double? Interesfinanc { get; set; }

    public double? Deudatotal { get; set; }

    public string? Cobradototalmente { get; set; }

    public string? Inspector { get; set; }

    public string? Observaciones { get; set; }

    public double? Importecobrado { get; set; }

    public double? Diferencia { get; set; }

    public double? Año { get; set; }

    public double? Ejercicio { get; set; }

    public double? Cantidadcuotas { get; set; }

    public double? Cuotasdevengadas { get; set; }

    public string? Adevengar { get; set; }

    public string? Devengado { get; set; }

    public string? Total { get; set; }

    public DateTime? FechaVencActa { get; set; }

    public DateTime? FechaAsig { get; set; }

    public DateTime? AsigDesde { get; set; }

    public DateTime? AsigHasta { get; set; }

    public decimal? AsigDeudaAprox { get; set; }

    public int? Estado { get; set; }

    public int? Dias { get; set; }

    public int? Financiacion { get; set; }

    public decimal? Anticipo { get; set; }

    public decimal? Tasa { get; set; }

    public decimal? Coeficiente { get; set; }

    public decimal? ImporteCuota { get; set; }

    public int? EstudioJuridico { get; set; }

    public int? EstudioInspector { get; set; }

    public string? NumCertif { get; set; }

    public decimal? MontoCertif { get; set; }

    public decimal? MontoCertifActa { get; set; }

    public string? InspectorAnterior { get; set; }

    public DateTime? FechaAsigAnterior { get; set; }

    public int IdActa { get; set; }

    public string? CuitStr { get; set; }

    public int? InspectorId { get; set; }
}
