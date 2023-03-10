using Lab.EF.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logica.Empleados
{
    public class EmpleadoListaMensaje
    {
        public static void MensajeListaEmpleado(Employees item)
        {
            Console.WriteLine($"{item.FirstName} {item.LastName}");
        }
    }
}