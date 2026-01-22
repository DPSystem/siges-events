using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Articulos2024
{
    public int Id { get; set; }

    public int? Codigo { get; set; }

    public int? RubroId { get; set; }

    public int? SubRubroId { get; set; }

    public int? MarcaId { get; set; }

    public int? UsuarioId { get; set; }

    public string? CodigoDeBarra { get; set; }

    public string? Descripcion { get; set; }

    public string? Comentario { get; set; }

    public int? SexoId { get; set; }

    public int? ReservaQuinchoId { get; set; }

    public int? EsQuincho { get; set; }

    public int? EdadDesde { get; set; }

    public int? EdadHasta { get; set; }

    public int? BienDeUso { get; set; }

    public DateTime? FechaCarga { get; set; }

    public DateTime? FechaBaja { get; set; }

    public int? Estado { get; set; }
}
