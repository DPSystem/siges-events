using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Articulo1
{
    public int Id { get; set; }

    public string? Descripcion { get; set; }

    public string? CodigoDeBarra { get; set; }

    public int? Cantidad { get; set; }

    public int? Estado { get; set; }

    public string? Sexo { get; set; }

    public string? CodigoDelProveedor { get; set; }

    public int? StockInicial { get; set; }

    public int? ReservaQuinchoId { get; set; }
}
