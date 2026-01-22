using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Turno
{
    public int Id { get; set; }

    public int? ServicioId { get; set; }

    public DateTime? Dia { get; set; }

    public TimeOnly? Hora { get; set; }

    public string? CuilSocio { get; set; }

    public int? CuponId { get; set; }

    public byte? Estado { get; set; }

    public int? Localidad { get; set; }
}
