using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class ImpresionComprobante
{
    public int IdEntrega { get; set; }

    public int? NroEntrega { get; set; }

    public int? NroSocio { get; set; }

    public string? SocioApenom { get; set; }

    public string? SocioDni { get; set; }

    public string? SocioEmpresa { get; set; }

    public string? BenefApenom { get; set; }

    public string? BenefDni { get; set; }

    public int? BenefEdad { get; set; }

    public string? BenefTipoMochila { get; set; }

    public string? BenefSexo { get; set; }

    public string? BenefLegajo { get; set; }

    public string? BenefFdoDesempleo { get; set; }

    public string? Comentario { get; set; }

    public string? Campeonato { get; set; }

    public string? Equipo { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Hora { get; set; }

    public string? Fase { get; set; }

    public string? Categoria { get; set; }

    public string? Cancha { get; set; }

    public string? Partidoid { get; set; }

    public string? Nrofecha { get; set; }

    public string? Col1nombre { get; set; }

    public string? Col1dni { get; set; }

    public string? Col1nrosocio { get; set; }

    public string? Col1empresa { get; set; }

    public byte[]? Col1foto { get; set; }

    public string? Col2nombre { get; set; }

    public string? Col2dni { get; set; }

    public string? Col2nrosocio { get; set; }

    public string? Col2empresa { get; set; }

    public byte[]? Col2foto { get; set; }

    public string? SancionXDe { get; set; }

    public string? SancionCantidad { get; set; }

    public string? Empresa { get; set; }

    public string? Desde { get; set; }

    public string? Hasta { get; set; }

    public DateTime? Periodo { get; set; }

    public string? Cuit { get; set; }

    public string? Localidad { get; set; }

    public string? Domicilio { get; set; }

    public string? Estudio { get; set; }

    public int? Rectificacion { get; set; }

    public string? Telefono { get; set; }

    public decimal? AporteLey { get; set; }

    public decimal? AporteSocio { get; set; }

    public string? Fechapago { get; set; }

    public decimal? ImporteDepositado { get; set; }

    public int? CantidadEmpleados { get; set; }

    public int? CantidadSocios { get; set; }

    public decimal? Capital { get; set; }

    public decimal? Interes { get; set; }

    public decimal? Total { get; set; }

    public DateTime? Fecha1 { get; set; }

    public DateTime? Fecha2 { get; set; }

    public DateTime? Fecha3 { get; set; }

    public DateTime? Fecha4 { get; set; }

    public DateTime? Fecha5 { get; set; }
}
