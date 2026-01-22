using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class CuponArt
{
    public int CuponArtId { get; set; }

    public int CuponArtEventCuponId { get; set; }

    public int CuponArtEventArtId { get; set; }

    public int CuponArtEntrega { get; set; }
}
