using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class ReservasQuincho
{
    public int Id { get; set; }

    public DateTime Fecha { get; set; }

    public DateTime? FechaEvento { get; set; }

    public int? Numero { get; set; }

    public int QuinchoId { get; set; }

    public int SocioId { get; set; }

    public int EventoId { get; set; }

    public int? CantInvitados { get; set; }

    public string? FiestaDesde { get; set; }

    public string? FiestaHasta { get; set; }

    public string? LlavesDesde { get; set; }

    public string? LlavesHasta { get; set; }

    public int? CantTenedor { get; set; }

    public int? CantCuchillos { get; set; }

    public int? CantVasos { get; set; }

    public int? CantTablones { get; set; }

    public int? CantSillas { get; set; }

    public int? CantMesaRedonda { get; set; }

    public decimal? Costo { get; set; }

    public string? Comentario { get; set; }

    public DateTime? FechaVencReserva { get; set; }

    public DateTime? FechaDeCancelacion { get; set; }

    public DateTime? FechaDeConfirmacion { get; set; }

    public int? Estado { get; set; }
}
