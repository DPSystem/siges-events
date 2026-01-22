using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Recibo
{
    public int Id { get; set; }

    public int? NroAutomatico { get; set; }

    public DateTime? FechaAutomatica { get; set; }

    public string? NroManual { get; set; }

    public string? FechaManual { get; set; }

    public int? NroDeActa { get; set; }

    public decimal? Importe { get; set; }

    public int? UsuarioId { get; set; }

    public int? Estado { get; set; }

    public int? Aprobado { get; set; }

    public int? AprobadoUsuarioId { get; set; }

    public DateTime? AprobadoFecha { get; set; }

    public int? NroReservaQuincho { get; set; }
}
