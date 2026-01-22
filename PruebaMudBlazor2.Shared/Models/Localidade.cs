using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Localidade
{
    public int Id { get; set; }

    public int Idlocalidades { get; set; }

    public int? Idprovincias { get; set; }

    public string? Nombre { get; set; }

    public string? Codigopostal { get; set; }
}
