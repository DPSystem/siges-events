using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Maeemp
{
    public double MaeempCuit { get; set; }

    public string MaeempNomfan { get; set; } = null!;

    public string MaeempRazsoc { get; set; } = null!;

    public string MaeempCalle { get; set; } = null!;

    public string MaeempNro { get; set; } = null!;

    public string? MaeempCodprov { get; set; }

    public long? MaeempCodloc { get; set; }

    public string? MaeempCodpos { get; set; }

    public string? MaeempTel { get; set; }

    public string? MaeempEmail { get; set; }

    public long? MaeempCredmax { get; set; }

    public string? MaeempCondcred { get; set; }

    public int? MaeempCondiva { get; set; }

    public byte? MaeempActualiza { get; set; }

    public string? MaeempEstudioContacto { get; set; }

    public string? MaeempEstudioTel { get; set; }

    public string? MaeempEstudioEmail { get; set; }

    public string? MeempCuitStr { get; set; }

    public int Id { get; set; }
}
