using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class EstudiosContable
{
    public int Id { get; set; }

    public string? Cuit { get; set; }

    public string? RazonSocial { get; set; }

    public int? Estado { get; set; }

    public string? Email { get; set; }

    public string? Nombre { get; set; }

    public string? Telefono { get; set; }

    public string? Domicilio { get; set; }

    public string? Localidad { get; set; }

    public string? Telefono2 { get; set; }
}
