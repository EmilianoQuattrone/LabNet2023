using Lab.EF.Logica;

namespace Lab.EF.UI.Logica
{
    public class Empleados
    {
        public static void ObtenerEmpleados()
        {
            EmpleadosLogica empleadosLogica = new EmpleadosLogica();
            empleadosLogica.ListadoEmpleados();
        }
    }
}