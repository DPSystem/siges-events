using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Permiso
{
    public int IdPermiso { get; set; }

    public int IdPemisoRol { get; set; }

    public int IdPermisoUsuario { get; set; }
}
