using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPracticoN2.Validaciones;

namespace TrabajoPracticoN2.Clases
{
    public class Menu
    {
        public static void MenuUsuario(decimal opcion)
        {
            switch (opcion)
            {
                case 1:
                    Mensajes.MensajeDividendo();
                    decimal dividendoIngresado = Validar.ValidarEntradasNegativasYVacias("Solo ingresar numeros: ");
                    Ejercicios.EjercicioN1(dividendoIngresado);
                    break;
                case 2:
                    Mensajes.MensajeDividendo();
                    decimal dividendo = Validar.ValidarEntradasNegativasYVacias("Ingrese solo numero: ");
                    Mensajes.MensajeDivisor();
                    decimal divisor = Validar.ValidarEntradasNegativasYVacias("Ingrese solo numero: ");
                    Ejercicios.EjercicioN2(dividendo, divisor);
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    Mensajes.MensajeDefault();
                    decimal opcionDefault = Validar.ValidarEntradasNegativasYVacias("Ingrese solo numeros:");
                    MenuUsuario(opcionDefault);
                    break;
            }
        }
    }
}