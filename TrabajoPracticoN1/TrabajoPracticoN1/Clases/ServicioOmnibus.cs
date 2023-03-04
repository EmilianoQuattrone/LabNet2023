using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPracticoN1.Validaciones;

namespace TrabajoPracticoN1.Clases
{
    public class ServicioOmnibus
    {
       public static List<TransportePublico> transportePublico = new List<TransportePublico>();
       public static int contadorOmnibus = 1;

        public static void CargarOmnibus(int omnibusIngresado)

        {
            for (int indiceOmnibus = 1; indiceOmnibus <= omnibusIngresado; indiceOmnibus++)
            {
                Console.WriteLine($"Cargue los pasajeros del Omnibu {indiceOmnibus}");
                int pasajerosOmnibus = ValidarEntradas.Validar("Solo se admiten numeros.");

                transportePublico.Add(new Omnibus() { Pasajeros = pasajerosOmnibus, Id=contadorOmnibus });
                contadorOmnibus++;
            }
        }

        public static void ObtenerOmnibus()
        {
            foreach (var item in transportePublico)
            {
                Console.WriteLine($"Omnibus {item.Id}: tiene {item.Pasajeros} pasajeros.");
            }
        }

        public static int CantidadListaOmnibus()
        {
            return transportePublico.Count();
        }
    }
}
