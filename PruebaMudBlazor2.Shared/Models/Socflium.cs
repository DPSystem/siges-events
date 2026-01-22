using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Socflium
{
    public double SocfliaCuil { get; set; }

    public long SocfliaCodfliar { get; set; }

    public byte SocfliaEstado { get; set; }

    public int SocfliaParent { get; set; }

    public string? CuilStr { get; set; }
}
