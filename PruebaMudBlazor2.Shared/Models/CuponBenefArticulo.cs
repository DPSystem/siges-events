using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class CuponBenefArticulo
{
    public int Id { get; set; }

    public int NroCupon { get; set; }

    public string Cuil { get; set; }

    public int CodigoFliar { get; set; }

    public int ArticuloId { get; set; }

    public int EventoId { get; set; }

    public int Estado { get; set; }
}
