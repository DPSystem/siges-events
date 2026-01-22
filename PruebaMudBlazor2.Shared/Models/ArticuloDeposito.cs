using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class ArticuloDeposito
{
    public int Id { get; set; }

    public int? ArticuloId { get; set; }

    public int? DepositoId { get; set; }

    public int? ArticulosMovsId { get; set; }

    public int? ArticulosMovsNumero { get; set; }

    public int? Cantidad { get; set; }

    public DateTime? Fecha { get; set; }

    public int? UsuarioId { get; set; }
}
