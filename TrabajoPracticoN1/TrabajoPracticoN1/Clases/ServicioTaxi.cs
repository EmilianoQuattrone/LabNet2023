using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPracticoN1.Validaciones;

namespace TrabajoPracticoN1.Clases
{
    public class ServicioTaxi
    {

      public static List<TransportePublico> transportePublico = new List<TransportePublico>();
      public static int contadorTaxis = 1;
        public static void CargarTaxis(int taxisIngresado)
        {
            for (int indiceTaxis = 1; indiceTaxis <= taxisIngresado; indiceTaxis++)
            {
                Console.WriteLine($"Cargue los pasajeros del Taxi {indiceTaxis}");
                int pasajerosTaxi = ValidarEntradas.Validar("Solo se admiten numeros.");
                transportePublico.Add(new Taxi() { Pasajeros = pasajerosTaxi , Id= contadorTaxis});
                contadorTaxis++;
            }
        }

        public static void ObtenerTaxis()
        {
            foreach (var item in transportePublico)
            {
                Console.WriteLine($"Taxis {item.Id}: tiene {item.Pasajeros} pasajeros.");
            }
        }

       public static int CantidadListadoTaxi()
        {
            return transportePublico.Count();
        }
    }
}
