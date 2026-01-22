using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Cheque
{
    public int Id { get; set; }

    public int? NroDeRecibo { get; set; }

    public string? NroDeCheque { get; set; }

    public DateTime? FechaDeEmision { get; set; }

    public DateTime? FechaDePresentacion { get; set; }

    public DateTime? FechaDeVencimiento { get; set; }

    public decimal? Importe { get; set; }

    public int? BancoId { get; set; }

    public string? Emisor { get; set; }

    public string? Cuit { get; set; }

    public string? NroDeCuenta { get; set; }

    public string? NroDeOperacion { get; set; }

    public string? NroDeTransferencia { get; set; }

    public int? Estado { get; set; }
}
