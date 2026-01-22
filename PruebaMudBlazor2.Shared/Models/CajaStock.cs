using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class CajaStock
{
    public int Id { get; set; }

    public int? NroDeCaja { get; set; }

    public int? ArticuloId { get; set; }

    public int? ArticuloCodigo { get; set; }

    public int? Inicial { get; set; }

    public int? Vendido { get; set; }

    public int? Final { get; set; }

    public int? Relevado { get; set; }

    public int? Sobrante { get; set; }

    public int? Faltante { get; set; }

    public DateTime? FechaCierre { get; set; }

    public int? Estado { get; set; }

    public int? UsuarId { get; set; }
}
