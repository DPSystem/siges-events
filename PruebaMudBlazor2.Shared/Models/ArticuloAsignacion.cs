using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class ArticuloAsignacion
{
    public int Id { get; set; }

    public int? ArituculoId { get; set; }

    public int? Cantidad { get; set; }

    public int? ReservaQuinchoId { get; set; }

    public int? ReservaNumero { get; set; }

    public int? EventoId { get; set; }

    public int? Estado { get; set; }
}
