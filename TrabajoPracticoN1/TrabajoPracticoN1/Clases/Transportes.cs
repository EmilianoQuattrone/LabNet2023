using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPracticoN1.Menus;
using TrabajoPracticoN1.Validaciones;

namespace TrabajoPracticoN1.Clases
{
    public class Transportes
    {
        public static void CargarOmnibus()
        {
            int omnibusIngresado = ValidarEntradas.Validar("Solo se admiten numeros.");
            while (OtrasValidaciones.ValidarEntradaNegativa(omnibusIngresado) ||
                OtrasValidaciones.ValidarEntradaMaxima(omnibusIngresado)) 
            {
                Console.WriteLine("Numero negativo o mayor a 5");
                omnibusIngresado = ValidarEntradas.Validar("Solo se admiten numeros.");
            }
            ServicioOmnibus.CargarOmnibus(omnibusIngresado);
            ServicioOmnibus.ObtenerOmnibus();

            if (ServicioTaxi.CantidadListadoTaxi() <= 5 )
            {
                Console.WriteLine("Cargar taxis presione 1 - presione 2 para listar todo");
                
                int cargarTaxis = ValidarEntradas.Validar("Ingrese solo numeros");
                if(cargarTaxis == 1 )
                {
                    CargarTaxis();
                } 
                else
                {
                    ServicioOmnibus.ObtenerOmnibus();
                    ServicioTaxi.ObtenerTaxis();
                }
            }
        }

        public static void CargarTaxis()
        {
            int taxisIngresados = ValidarEntradas.Validar("Solo se admiten numeros.");
            while (OtrasValidaciones.ValidarEntradaNegativa(taxisIngresados) ||
                OtrasValidaciones.ValidarEntradaMaxima(taxisIngresados))
            {
                Console.WriteLine("Numero negativo o mayor a 5");
                taxisIngresados = ValidarEntradas.Validar("Solo se admiten numeros.");
            }

            ServicioTaxi.CargarTaxis(taxisIngresados);
            ServicioTaxi.ObtenerTaxis();

            if (ServicioOmnibus.CantidadListaOmnibus() <= 5)
            {
                Console.WriteLine("Cargar omnibus presione 1 - presione 2 para listar todo");
                int cargarOmnibus = ValidarEntradas.Validar("Ingrese solo numeros");
                if (cargarOmnibus == 1)
                {
                    CargarOmnibus();
                }
                else
                {
                    ServicioTaxi.ObtenerTaxis();
                    ServicioOmnibus.ObtenerOmnibus();
                }
            }
        }
    }
}