using System;

namespace TrabajoPracticoN1.Validaciones
{
    public class ValidarEntradas
    {
        //Youtube 
        public static int Validar(string mensaje)
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