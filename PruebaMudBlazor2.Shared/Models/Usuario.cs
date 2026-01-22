using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public int IdRol { get; set; }

    public string Apellido { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string? Domicilio { get; set; }

    public string? Dni { get; set; }

    public string? Tel1 { get; set; }

    public string? Tel2 { get; set; }

    public string? Usuario1 { get; set; }

    public string Password { get; set; } = null!;

    public int? CobradorId { get; set; }
}
