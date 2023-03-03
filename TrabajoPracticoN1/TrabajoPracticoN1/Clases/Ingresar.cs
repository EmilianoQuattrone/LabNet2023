using System;
using System.Collections.Generic;
using TrabajoPracticoN1.Validaciones;

namespace TrabajoPracticoN1.Clases
{
    public class Ingresar
    {
        public static void IngresarOmnibus()
        {
            int contadorOmnibus = 1;
            Omnibus omnibus = new Omnibus();
            List<int> listaOmnibus = new List<int>();

            Console.WriteLine("Solo puede ingresar 5 Omnibus.");
            Console.WriteLine("Ingrese Omnibus: ");
            int cantidadOmnibus = ValidarEntradas.Validar("Ingrese solo numeros");

            while (cantidadOmnibus > 5)
            {
                Console.WriteLine("Cantidad Maxima permitida es 5.");
                Console.WriteLine("Intente de nuevo");
                cantidadOmnibus = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= cantidadOmnibus; i++)
            {
                Console.WriteLine($"Cargue pasajeros del Omnibus {i}: ");
                listaOmnibus.Add(omnibus.Pasajeros = ValidarEntradas.Validar("Solo se puede ingresar numero."));
            }

            Console.WriteLine("¿Quiere cargar Taxis? - presione 1 para confirmar");
            Console.WriteLine("Presione 2 para listar.");

            var bandera = 0;
            while (bandera == 0)
            {
                var opTaxis = Console.ReadLine();
                switch (opTaxis)
                {
                    case "1":
                        Ingresar.IngresarTaxis();
                        foreach (int list in listaOmnibus)
                        {
                            Console.WriteLine($"Omnibus {contadorOmnibus++}: tiene {list} pasajeros.");
                        }
                        omnibus.Avanzar();
                        bandera = 1;
                        break;

                    case "2":
                        foreach (int list in listaOmnibus)
                        {
                            Console.WriteLine($"Omnibus {contadorOmnibus++}: tiene {list} pasajeros.");
                        }
                        omnibus.Avanzar();
                        bandera = 1;
                        break;

                    default:
                        Console.WriteLine("Opcion no valida presione una tecla para continuar.");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("¿Quiere cargar Taxis? - presione 1 para confirmar");
                        Console.WriteLine("Presione 2 para listar.");
                        break;
                }
            }
        }

        public static void IngresarTaxis()
        {
            int contadorTaxis = 1;
            Taxi taxis = new Taxi();
            List<int> listaTaxis = new List<int>();

            Console.WriteLine("Solo puede ingresar 5 Taxis.");
            Console.WriteLine("Ingrese Taxis: ");
            int cantidadTaxis = ValidarEntradas.Validar("Solo se puede ingresar numeros.");

            while (cantidadTaxis > 5)
            {
                Console.WriteLine("Cantidad Maxima permitida es 5.");
                Console.WriteLine("Intente de nuevo");
                cantidadTaxis = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= cantidadTaxis; i++)
            {
                Console.WriteLine($"Cargue pasajeros del Taxis {i}: ");
                listaTaxis.Add(taxis.Pasajeros = ValidarEntradas.Validar("Solo se puede ingresar numero."));
            }

            Console.WriteLine("¿Quiere cargar Omnibus? - presione 1 para confirmar");
            Console.WriteLine("Presione 2 para listar.");

            var bandera = 0;
            while (bandera == 0)
            {

                var opOmnibu = Console.ReadLine();

                switch (opOmnibu)

                {
                    case "1":

                        Ingresar.IngresarOmnibus();
                        foreach (int list in listaTaxis)
                        {
                            Console.WriteLine($"Taxi {contadorTaxis++}: tiene {list} pasajeros.");
                        }
                        taxis.Avanzar();
                        bandera = 1;
                        break;

                    case "2":

                        foreach (int list in listaTaxis)
                        {
                            Console.WriteLine($"Taxi {contadorTaxis++}: tiene {list} pasajeros.");
                        }
                        taxis.Avanzar();
                        bandera = 1;
                        break;

                    default:
                        Console.WriteLine("Opcion no valida presione una tecla para continuar.");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("¿Quiere cargar Omnibus? - presione 1 para confirmar");
                        Console.WriteLine("Presione 2 para listar.");
                        break;
                }
            }

        }
    }
}