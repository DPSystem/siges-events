using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class EventosCupone1
{
    public int EventcuponId { get; set; }

    public int EventcuponEventoId { get; set; }

    public double EventcuponMaesocCuil { get; set; }

    public int EventcuponMaefliaCodfliar { get; set; }

    public int EventCuponEventExepId { get; set; }

    public int EventCuponNro { get; set; }

    public DateTime EventCuponFecha { get; set; }

    public int? CajaId { get; set; }

    public int? UsuarioId { get; set; }

    public decimal? Costo { get; set; }

    public int? Invitado { get; set; }

    public int? ComprobanteId { get; set; }

    public int? ArticuloId { get; set; }

    public string? QuienRetiraCupon { get; set; }

    public int? FondoDeDesempleo { get; set; }

    public DateTime? FechaDeEntregaArticulo { get; set; }

    public int? ArticuloIdretira { get; set; }

    public int? UsuarioIdCheckRetiro { get; set; }
}
