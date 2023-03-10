using Lab.EF.Entidades;
using Lab.EF.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpleadosLogica empleadosLogica = new EmpleadosLogica();

            foreach (Employees empleados in  empleadosLogica.ObtenerEmpleados()) 
            {
                Console.WriteLine($"Nombre completo: {empleados.FirstName} {empleados.LastName}");
            }

            Console.WriteLine("Categorias: ");

            CategoriasLogica categoriasLogica = new CategoriasLogica();

            foreach (Categories categorias in categoriasLogica.ObtenerCategorias())
            {
                Console.WriteLine($"Categorias: {categorias.CategoryName}");
            }

            Console.ReadKey();
        }
    }
}
