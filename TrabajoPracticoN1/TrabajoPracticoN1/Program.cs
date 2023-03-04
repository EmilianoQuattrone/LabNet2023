using System;
using System.Collections.Generic;
using TrabajoPracticoN1.Clases;
using TrabajoPracticoN1.Menus;
using TrabajoPracticoN1.Validaciones;

namespace TrabajoPracticoN1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuApp.Menu();           
            MenuPrograma.CargarTransportes();
            MenuFinPrograma.MenuFin();
        }
    }
}