using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Soccen
{
    public double SoccenCuil { get; set; }

    public byte SoccenEstado { get; set; }

    public int SoccenCodiva { get; set; }

    public DateOnly? SoccenFeing { get; set; }

    public DateOnly? SoccenFebaja { get; set; }

    public int SoccenNrorescomdir { get; set; }

    public long SoccenCredmax { get; set; }

    public string SoccenCondcred { get; set; } = null!;

    public byte SoccenSocdir { get; set; }

    public byte SoccenDespedido { get; set; }

    public byte? SoccenActualiza { get; set; }
}
