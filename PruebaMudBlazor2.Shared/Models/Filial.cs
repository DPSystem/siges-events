using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Filial
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Domicilio { get; set; }

    public string? Localidad { get; set; }

    public string? Telefono { get; set; }

    public string? Provincia { get; set; }

    public string? Email { get; set; }

    public string? SecretarioGeneral { get; set; }

    public string? SubSecretario { get; set; }

    public string? SecretariaDeLaMujer { get; set; }

    public int? SorteoConfig { get; set; }

    public string? NombreCorto { get; set; }

    public string? Aux1 { get; set; }

    public string? Aux2 { get; set; }

    public decimal? PorcentajeDescuentoLey { get; set; }

    public decimal? PorcentajeDescuentoSocio { get; set; }

    public decimal? InteresMensualPorMora { get; set; }

    public DateTime? CarenciaMochilas { get; set; }

    public string? PathBaser { get; set; }
}
