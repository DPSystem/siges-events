using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Evento
{
    public int EventosId { get; set; }

    public string EventosNombre { get; set; } = null!;

    public int EventosEstado { get; set; }

    public DateTime? EventosInicio { get; set; }

    public DateTime? EventosFin { get; set; }

    public TimeOnly? EventosHorafin { get; set; }
}
