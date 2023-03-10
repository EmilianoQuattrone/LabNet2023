using Lab.EF.Data;
using Lab.EF.Entidades;
using Lab.EF.Logica.Empleados;
using System.Collections.Generic;
using System.Linq;

namespace Lab.EF.Logica
{
    public class EmpleadosLogica : NorthwindLogica, ICRUD<Employees>
    {
        public List<Employees> ObtenerTodos()
        {
            return northwindContext.Employees.ToList();
        }

        public void ListadoEmpleados()
        {
            foreach (var item in ObtenerTodos())
            {
                EmpleadoListaMensaje.MensajeListaEmpleado(item);
            }
        }

        public void Add(Employees entidad)
        {
        }

        public void Modificar(Employees empleado)
        {         
        }
        public void Eliminar(int id)
        { 
        }
    }
}