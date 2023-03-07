using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoN2.Validaciones
{
    public class Validar
    {
        public static decimal ValidarEntradasNegativasYVacias(string mensaje)

        {
            decimal valor;
            Console.WriteLine(mensaje);
            string validarNumero = Console.ReadLine();

            while (!decimal.TryParse(validarNumero, out valor))

            {
                Console.WriteLine(mensaje);
                validarNumero = Console.ReadLine();
            }
            return valor;
        }
    }
}