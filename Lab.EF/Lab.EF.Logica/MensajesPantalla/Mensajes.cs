using System;
using System.Data.Entity.Validation;

namespace Lab.EF.Logica.Excepciones
{
    public class Mensajes
    {
        public static void MensajeExcepciones(DbEntityValidationException ex)
        {
            string mensaje = "Cantidad maxima de letras 15..";
            Console.WriteLine($"{ex.Message}. \n{mensaje}");
        }
    }
}