using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Parentesco
{
    public int ParentId { get; set; }

    public string ParentDescrip { get; set; } = null!;

    public int ParentEstado { get; set; }

    public int ParentCodigo { get; set; }
}
