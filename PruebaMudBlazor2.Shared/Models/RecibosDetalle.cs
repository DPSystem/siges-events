using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class RecibosDetalle
{
    public int Id { get; set; }

    public int? CuotaId { get; set; }

    public int? NroCuota { get; set; }

    public int? NroAut { get; set; }

    public DateTime? FechaAut { get; set; }

    public int? NroManual { get; set; }

    public DateTime? FechaManual { get; set; }

    public int? TipoId { get; set; }

    public int? ConceptoId { get; set; }

    public int? ModoPagoId { get; set; }

    public int? UsuarioId { get; set; }

    public decimal? Importe { get; set; }

    public int? Estado { get; set; }
}
