using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Foto
{
  [Key] // Añade la clave (si ya tienes una propiedad adecuada, úsala)
  public int Id { get; set; }
  public double FotosCuil { get; set; }

  public double FotosCodfliar { get; set; }

  public byte[] FotosFoto { get; set; } = null!;

  public DateOnly FotosFecha { get; set; }

  public string? CuilStr { get; set; }
}
