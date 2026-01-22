using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class ActasDetalle1
{
    public int Id { get; set; }

    public DateTime Periodo { get; set; }

    public int CantidadEmpleados { get; set; }

    public int CantidadSocios { get; set; }

    public decimal TotalSueldoEmpleados { get; set; }

    public decimal TotalSueldoSocios { get; set; }

    public decimal TotalAporteEmpleados { get; set; }

    public decimal TotalAporteSocios { get; set; }

    public DateTime FechaDePago { get; set; }

    public decimal ImporteDepositado { get; set; }

    public int DiasDeMora { get; set; }

    public decimal DeudaGenerada { get; set; }

    public decimal InteresGenerado { get; set; }

    public decimal Total { get; set; }

    public int PerNoDec { get; set; }

    public int ActaId { get; set; }

    public int NumeroDeActa { get; set; }
}
