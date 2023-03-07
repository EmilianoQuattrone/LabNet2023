using System;

namespace TrabajoPracticoN2.Clases
{
    public class Mensajes
    {
        public static void MensajesConsola()
        {
            Console.WriteLine("Presione 1 para ejercicio N-1");
            Console.WriteLine("Presione 2 para ejercicio N-2");
            Console.WriteLine("Presione 3 para ejercicio N-3");
            Console.WriteLine("Presione 4 para ejercicio N-5");
        }

        public static void MensajeDividendo()
        {
            Console.WriteLine("Ingrese dividendo: ");
        }

        public static void MensajeDivisor()
        {
            Console.WriteLine("Ingrese divisor: ");
        }

        public static void MensajeDivisionEn0(string mensaje)
        {
            string mensajeChuckNorris = "Solo Chuck Norris divide por cero!";
            Console.WriteLine($"{mensaje} {mensajeChuckNorris}");
        }

        public static void MensajeFinally()
        {
            Console.WriteLine("Termino de realizarse la operacion.");
        }

        public static void MensajeDefault()
        {
            Console.WriteLine("Opcion no valida, opciones validas 1,2,3 o 4");
        }

        public static void MensajeDefault2()
        {
            Console.WriteLine("Opcion no valida, presione 1 para volver a empezar");
        }
        public static void MensajeFinDePrograma()
        {
            Console.WriteLine("Fin del programa...");
            Console.ReadKey();
        }

        public static void MensajeResultadoDivision(decimal resultado)
        {
            Console.WriteLine($"El resultado de la division es: {resultado}");
        }

        public static void TituloEjercicioN3()
        {
            Console.WriteLine("EJERCICIO 3: ");
        }

        public static void TituloEjercicioN4()
        {
            Console.WriteLine("EJERCICIO 4: ");
        }
        public static void MensajeEjercicioN3(string mensaje)
        {
            Console.WriteLine($"Mensaje de la Excepcion Original: {mensaje}");
        }

        public  static void MensajeTipo(Exception ex)
        {
            Console.WriteLine($"Tipo de excepcion: {ex.GetType()}");
        }

        public static void MensajeEjercicioN4(string mensaje)
        {
            Console.WriteLine($"Mensaje de la Excepcion Original: {mensaje}");
        }

        public static void MensajeTipoEJ4(Exception ex)
        {
            Console.WriteLine($"Tipo de excepcion: {ex.GetType()}");
        }
    }
}
