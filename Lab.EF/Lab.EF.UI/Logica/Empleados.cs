using Lab.EF.Entidades;
using Lab.EF.Logica;
using Lab.EF.UI.InterfazUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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