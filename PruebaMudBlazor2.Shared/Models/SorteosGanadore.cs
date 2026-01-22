using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class SorteosGanadore
{
    public int Id { get; set; }

    public int? NumeroDeSorteo { get; set; }

    public string? Dni { get; set; }

    public string? Apellido { get; set; }

    public string? Nombre { get; set; }

    public string? Premio { get; set; }

    public string? Dnisocio { get; set; }

    public string? ApeNomSocio { get; set; }

    public int? NroSocio { get; set; }

    public string? Empresa { get; set; }

    public string? TelefonoEmpresa { get; set; }

    public string? TelefonoSocio { get; set; }

    public DateTime? Fecha { get; set; }
}
