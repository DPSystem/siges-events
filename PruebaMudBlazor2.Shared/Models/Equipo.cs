using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Equipo
{
    public int Equipoid { get; set; }

    public string Equiponombre { get; set; } = null!;

    public int EquipoCatid { get; set; }

    public int? EquipoGrupoid { get; set; }
}
