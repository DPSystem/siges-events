using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class SancionesAnt
{
    public int IdSancion { get; set; }

    public int IdJug { get; set; }

    public int CantidadFechas { get; set; }

    public DateTime FechaDesde { get; set; }

    public DateTime FechaHasta { get; set; }

    public DateTime FechaPartido { get; set; }

    public int NroFecha { get; set; }

    public int? IdPartido { get; set; }
}
