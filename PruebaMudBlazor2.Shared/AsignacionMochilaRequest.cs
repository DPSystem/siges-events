using PruebaMudBlazor2.Shared.Models;
using System.Collections.Generic;

namespace PruebaMudBlazor2.Shared
{
    public class AsignacionMochilaRequest
    {
        public List<Alumno> Alumnos { get; set; }
        public int NroDeReserva { get; set; }
    }
}
