namespace PruebaMudBlazor2.Services
{
  /// <summary>
  /// DTO para mostrar reservas pendientes de aprobación
  /// </summary>
  public class ReservaPendiente
  {
    public int NroReserva { get; set; }
    public DateTime FechaReserva { get; set; }
    public double CuilSocio { get; set; }
    public string ApellidoNombre { get; set; } = string.Empty;
    public string NroSocio { get; set; } = string.Empty;
    public string Dni { get; set; } = string.Empty;
    public string Celular { get; set; } = string.Empty;
    public int Estado { get; set; } // 0=No Entregado, 1=Entregado, 2=Pendiente, 3=No Aprobado
    public List<DetalleBeneficiario> Beneficiarios { get; set; } = new();
  }

  /// <summary>
  /// Detalle de cada beneficiario en la reserva
  /// </summary>
  public class DetalleBeneficiario
  {
    public int CodigoFliar { get; set; }
    public string NombreBeneficiario { get; set; } = string.Empty;
    public string Articulo { get; set; } = string.Empty;
    public int ArticuloId { get; set; }
    public int Estado { get; set; }
  }
}
