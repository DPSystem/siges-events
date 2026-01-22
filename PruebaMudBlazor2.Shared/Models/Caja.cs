using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Caja
{
    public int Id { get; set; }

    public int NroDeCaja { get; set; }

    public int UserId { get; set; }

    public DateTime? FechaApertura { get; set; }

    public decimal? MontoApertura { get; set; }

    public DateTime? FechaCierre { get; set; }

    public decimal? MontoTotal { get; set; }

    public decimal? MontoEfectivo { get; set; }

    public decimal? MontoTransferecia { get; set; }

    public decimal? MontoCuentaCorriente { get; set; }

    public decimal? MontoTarjeta { get; set; }

    public decimal? MontoCheque { get; set; }

    public decimal? CargaEfectivo { get; set; }

    public decimal? CargaTransferencia { get; set; }

    public decimal? CargaCuentaCorriente { get; set; }

    public decimal? CargaTarjeta { get; set; }

    public decimal? CargaCheque { get; set; }

    public decimal? SobranteEfectivo { get; set; }

    public decimal? SobranteTransferencia { get; set; }

    public decimal? SobranteCuentaCorriente { get; set; }

    public decimal? SobranteTarjeta { get; set; }

    public decimal? SobranteCheque { get; set; }

    public decimal? FaltanteEfectivo { get; set; }

    public decimal? FaltanteTransferencia { get; set; }

    public decimal? FaltanteCuentaCorriente { get; set; }

    public decimal? FaltanteTarjeta { get; set; }

    public decimal? FaltanteCheque { get; set; }
}
