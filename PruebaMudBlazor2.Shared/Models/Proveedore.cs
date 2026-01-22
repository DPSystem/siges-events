using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Proveedore
{
    public int Id { get; set; }

    public int? UsuarioId { get; set; }

    public string? Nombre { get; set; }

    public string? RazonSocial { get; set; }

    public string? Cuit { get; set; }

    public string? Cbu { get; set; }

    public string? Alias { get; set; }

    public string? CuentaBancaria { get; set; }

    public DateTime? FechaAlta { get; set; }

    public int? Estado { get; set; }

    public string? Email { get; set; }

    public string? Telefono { get; set; }

    public string? Cuenta { get; set; }

    public int? BancoId { get; set; }

    public int? InformaVenc { get; set; }
}
