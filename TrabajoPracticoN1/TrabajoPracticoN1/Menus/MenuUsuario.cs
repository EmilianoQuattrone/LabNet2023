using System;
using TrabajoPracticoN1.Clases;

namespace TrabajoPracticoN1.Menus
{
    public class MenuUsuario
    {
        public static void MenuOpciones()
        {

            var bandera = 0;
            while (bandera == 0)

            {
                var opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Ingresar.IngresarOmnibus();
                        bandera = 1;
                        break;

                    case "2":
                        Ingresar.IngresarTaxis();
                        bandera = 1;
                        break;

                    default:
                        Console.WriteLine("Opcion no valida presione una tecla para continuar..");
                        Console.ReadKey();
                        Console.Clear();
                        MenuApp.Menu();
                        break;
                }
            }
            
        }
    }
}