using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Jugadore
{
    public int Jugid { get; set; }

    public int JugEquipoid { get; set; }

    public double JugSoccencuil { get; set; }

    public string? JugMaesocNroafil { get; set; }

    public string? JugApellido { get; set; }

    public string? JugNombre { get; set; }

    public int? JugEstado { get; set; }

    public int? JugTipo { get; set; }

    public byte[]? JugFoto { get; set; }

    public string? JugEmpresa { get; set; }
}
