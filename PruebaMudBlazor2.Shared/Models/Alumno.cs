using System;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared.Models;

public partial class Alumno
{
    public int AlumnoId { get; set; }
    public string NroSocio { get; set; }
    public string Apellido { get; set; }
    public string Nombre { get; set; }
    public string Domicilio { get; set; }
    public string Telefono { get; set; }
    public string Sexo { get; set; }
    public string Mail { get; set; }
    public string Celular { get; set; }
    public string Foto { get; set; }
    public string Dni { get; set; }
    public double CuilTitular { get; set; }
    public int CodiGoDeFamiliar { get; set; }
    public string Apenom { get; set; }
    public DateTime? FechaNac { get; set; }
    public int Mochila { get; set; }
    public string URLImage { get; set; }
    public int? Edad
    {
        get
        {
            if (FechaNac.HasValue)
            {
                var today = DateTime.Today;
                var age = today.Year - FechaNac.Value.Year;
                if (FechaNac.Value.Date > today.AddYears(-age)) age--;
                return age;
            }
            return null;
        }
    }
    public string CicloEscolar { get; set; }

}
