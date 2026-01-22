namespace PruebaMudBlazor2.Shared
{
  public class FuncUtiles
  {
    public static int CalcularEdad(DateTime fechaNacimiento)
    {
      int edad = DateTime.Today.Year - fechaNacimiento.Year;
      if (fechaNacimiento > DateTime.Today.AddYears(-edad))
      {
        edad--;
      }
      return edad;
    }

    public static bool CalcularEdadMaternal (DateTime Fnac)
    {
      // Fecha actual
      DateTime fechaActual = DateTime.Now;

      // Año y mes límite para la entrega de regalos
      int anioLimite = fechaActual.Year ; 
      int mesLimite = 6; 
      int diaLimite = 30; 

      DateTime fechaLimite = new DateTime(anioLimite, mesLimite, diaLimite);

      return Fnac.AddYears(3) >= fechaLimite;
    }
  }
}
