using EF.Logica.Customer;
using System;

namespace PracticaLINQ.MensajesUI
{
    public class Mensajes
    {
        public static void MensajeCustomer(CustomerDtos cd)
        {
            Console.WriteLine($"Id: {cd.Id} - Nombre: {cd.Nombre}");
        }

        public static void MensajeExcepcion(Exception ex)
        {
            Console.WriteLine($"Error al intentar Obtener los Customer. \n{ex}");
        }

        public static void FinDePrograma()
        {
            Console.WriteLine("Fin del programa.");
            Console.ReadLine();
        }
    }
}