using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Banco
{
    public int Id { get; set; }

    public int? BanId { get; set; }

    public int? BanNro { get; set; }

    public string? BanNombre { get; set; }

    public string? BanSucursal { get; set; }

    public string? BanDireccion { get; set; }

    public string? BanTelefono { get; set; }

    public string? BanContacto { get; set; }

    public string? BanObs { get; set; }

    public int? BanBantId { get; set; }

    public int? BanSucId { get; set; }
}
