using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Cajas2024
{
    public int Id { get; set; }

    public int NumeroDeCaja { get; set; }

    public int UserId { get; set; }

    public int Total { get; set; }

    public DateTime? FechaApertura { get; set; }

    public DateTime? FechaCierre { get; set; }
}
