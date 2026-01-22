using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class EntregasMochila
{
    public int IdEntrega { get; set; }

    public int? CodFliar { get; set; }

    public int? NroDocFliar { get; set; }

    public bool? RecibeDocum { get; set; }

    public DateTime? FechaRecepcionDocum { get; set; }

    public int? TipoMochila { get; set; }

    public int? CodigoUsuarioRecepcion { get; set; }

    public bool? EntregaMochila { get; set; }

    public DateTime? FechaEntregaMochila { get; set; }

    public int? CodigoUsuarioEntrega { get; set; }

    public int? NumeroEntrega { get; set; }

    public bool? Exepcion { get; set; }

    public string? Comentario { get; set; }

    public string? Legajo { get; set; }

    public int? FondoDesempleo { get; set; }
}
