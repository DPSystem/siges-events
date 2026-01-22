using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class UsuariosObjeto
{
    public int UsuarioObjetoId { get; set; }

    public int? UsuarioId { get; set; }

    public int? ObjetoId { get; set; }

    public int? Estado { get; set; }

    public int? RolId { get; set; }
}
