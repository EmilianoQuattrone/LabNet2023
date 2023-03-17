using System;

namespace PracticaLINQ.OtrasFunciones
{
    public class Validar
    {
        public static int ValidarEntradasNegativasYVacias(string mensaje)

        {
            int valor;
            Console.WriteLine(mensaje);
            string validarNumero = Console.ReadLine();

            while (!int.TryParse(validarNumero, out valor))

            {
                Console.WriteLine(mensaje);
                validarNumero = Console.ReadLine();
            }
            return valor;
        }
    }
}