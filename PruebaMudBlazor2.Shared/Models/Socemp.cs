using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Socemp
{
    public double SocempCuil { get; set; }

    public double SocempCuite { get; set; }

    public byte SocempEstado { get; set; }

    public DateOnly SocempFechaing { get; set; }

    public DateOnly SocempFechabaja { get; set; }

    public string SocempCausabaja { get; set; } = null!;

    public string SocempNroleg { get; set; } = null!;

    public byte SocempSociocentro { get; set; }

    public string SocempUltEmpresa { get; set; } = null!;

    public string? SocempCuiteStr { get; set; }

    public string? SocempCuilStr { get; set; }
}
