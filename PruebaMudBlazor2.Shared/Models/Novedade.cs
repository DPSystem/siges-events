using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Novedade
{
    public int Id { get; set; }

    public DateTime? Fecha { get; set; }

    public int? IdActa { get; set; }

    public int? Acta { get; set; }

    public string? Novedad { get; set; }

    public int? UsuarioId { get; set; }

    public int? NumeroDeAsignacion { get; set; }

    public string? Cuit { get; set; }

    /// <summary>
    /// 1= tiene Mensaje - 0 = No tiene Mensaje
    /// </summary>
    public int? MensajeAlCobrador { get; set; }

    /// <summary>
    /// 1= Leido, 0 = Pendiente de Lectura
    /// </summary>
    public int? EstadoMensajeAlCobrador { get; set; }

    public int? Vd { get; set; }

    public DateTime? FechaCompromiso { get; set; }
}
