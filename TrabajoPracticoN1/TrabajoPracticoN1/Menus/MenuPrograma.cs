using System;
using TrabajoPracticoN1.Clases;
using TrabajoPracticoN1.Validaciones;

namespace TrabajoPracticoN1.Menus
{
    public class MenuPrograma
    {
        public static void CargarTransportes()
        {
            bool bandera = true;
            while (bandera == true)
            {
                int opcionIngresada = ValidarEntradas.Validar("Solo se admiten numeros");

                switch (opcionIngresada)
                {
                    case 1:
                        Console.WriteLine("Ingrese omnibus: ");
                        Transportes.CargarOmnibus();
                        bandera = false;
                        break;

                    case 2:
                        Console.WriteLine("Ingrese taxis: ");
                        Transportes.CargarTaxis();
                        bandera = false;
                        break;

                    default:
                        Console.WriteLine("Opcion no valida, presione cualquier tecla para continuar");
                        MenuApp.Menu();
                        break;
                }
            }    
        }
    }
}