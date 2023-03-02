using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPracticoN1.Clases;
using TrabajoPracticoN1.Menu;
using TrabajoPracticoN1.Menus;
using TrabajoPracticoN1.Validaciones;

namespace TrabajoPracticoN1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuApp.Menu();
            int opcion;

            //StackOverflow
            while (!int.TryParse(Console.ReadLine(), out opcion) || opcion > 2 || opcion == 0)
            {
                Console.WriteLine("Opcion no valida.");
            }
            MenuUsuario.MenuOpciones(opcion);
        }
    }
}