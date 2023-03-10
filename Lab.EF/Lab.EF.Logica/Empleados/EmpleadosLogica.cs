using Lab.EF.Data;
using Lab.EF.Entidades;
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

        public void Add(Employees entidad)
        {
            northwindContext.Employees.Add(entidad);
            northwindContext.SaveChanges();
        }

        public void Modificar(Employees employee)
        {
            
        }
        public void Eliminar(int id)
        {
        
        }
    }
}