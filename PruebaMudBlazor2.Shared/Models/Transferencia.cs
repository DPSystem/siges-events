using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Transferencia
{
    public int Id { get; set; }

    public int? NroDeRecibo { get; set; }

    public int? NroDeActa { get; set; }

    public string? NroDeTransf { get; set; }

    public int? BancoId { get; set; }

    public decimal? Monto { get; set; }

    public DateTime? FechaDeTransf { get; set; }

    public DateTime? FechaDeCarga { get; set; }

    public int? UsuarioId { get; set; }
}
