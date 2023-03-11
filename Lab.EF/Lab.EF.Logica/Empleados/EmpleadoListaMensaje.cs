using Lab.EF.Entidades;
using System;

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