using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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
