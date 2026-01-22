using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Maesoc
{
    public double MaesocCuil { get; set; }

    public string MaesocApellido { get; set; } = null!;

    public string MaesocNombre { get; set; } = null!;

    public string MaesocTel { get; set; } = null!;

    public string MaesocTelcel { get; set; } = null!;

    public DateOnly MaesocFechanac { get; set; }

    public short MaesocCargaflia { get; set; }

    public int MaesocJubil { get; set; }

    public byte? MaesocPredoc { get; set; }

    public DateOnly MaesocFechadoc { get; set; }

    public short MaesocCodcat { get; set; }

    public short MaesocCodact { get; set; }

    public int MaesocTipodoc { get; set; }

    public string MaesocNrodoc { get; set; } = null!;

    public int MaesocGruposang { get; set; }

    public string MaesocSexo { get; set; } = null!;

    public string MaesocEstciv { get; set; } = null!;

    public string MaesocCodprov { get; set; } = null!;

    public int MaesocCodloc { get; set; }

    public string MaesocCodpos { get; set; } = null!;

    public string? MaesocBarrio { get; set; }

    public string MaesocNacionalidad { get; set; } = null!;

    public string MaesocCalle { get; set; } = null!;

    public string MaesocNrocalle { get; set; } = null!;

    public string MaesocPiso { get; set; } = null!;

    public string MaesocDto { get; set; } = null!;

    public int MaesocCodosm { get; set; }

    public int? MaesocCodcon { get; set; }

    public string MaesocNroafil { get; set; } = null!;

    public string MaesocEmail { get; set; } = null!;

    public string MaesocEmaillab { get; set; } = null!;

    public string MaesocNrocarnet { get; set; } = null!;

    public string MaesocImpest1 { get; set; } = null!;

    public string MaesocImpest2 { get; set; } = null!;

    public string MaesocImpest3 { get; set; } = null!;

    public string MaesocImpest4 { get; set; } = null!;

    public string MaesocImpest5 { get; set; } = null!;

    public string MaesocImpest6 { get; set; } = null!;

    public string MaesocDebautCbu { get; set; } = null!;

    public double MaesocDebautMonto { get; set; }

    public byte? MaesocActualiza { get; set; }

    public int? MaesocDtofarmacia { get; set; }

    public DateOnly MaesocFechaalta { get; set; }

    public DateOnly MaesocFechamod { get; set; }

    public DateOnly MaesocFechadesempleo { get; set; }

    public string MaesocUsumod { get; set; } = null!;

    public string? Apenom { get; set; }

    public string? MaesocCuilStr { get; set; }
}
