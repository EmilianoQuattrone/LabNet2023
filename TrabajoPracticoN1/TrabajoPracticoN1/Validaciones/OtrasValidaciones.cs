using System;
using System.Collections.Generic;
using TrabajoPracticoN1.Clases;

namespace TrabajoPracticoN1.Validaciones
{
    internal class OtrasValidaciones
    {
        private const int cantidadMaxima = 5;

        public static bool ValidarEntradaMaxima(int opcion)
        {
            if (opcion > cantidadMaxima)
            {
                return true;
            }
            return false;
        }

        public static bool ValidarEntradaNegativa(int opcion)
        {

            if (opcion < 0)
            {
               return true;
            }

            return false;
        }
    }
}