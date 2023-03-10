using Lab.EF.Data;
using Lab.EF.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logica
{
    public class EmpleadosLogica : Northwind
    {
        public List<Employees> ObtenerEmpleados()
        {
            return northwindContext.Employees.ToList();
        }
    }
}