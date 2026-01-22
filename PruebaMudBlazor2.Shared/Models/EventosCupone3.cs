using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class EventosCupone3
{
    public int Id { get; set; }

    public DateTime? FechaGeneracion { get; set; }

    public int? EventoId { get; set; }

    public int? EventoAnioId { get; set; }

    public int? NroCupon { get; set; }

    public string? CuilTitular { get; set; }

    public string? CodigoFamiliar { get; set; }

    public string? DniFamiliar { get; set; }

    public int? UsuarioId { get; set; }

    public int? Estado { get; set; }

    public int? Exepcion { get; set; }
}
