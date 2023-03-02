using System;

namespace TrabajoPracticoN1.Clases
{
    public class Omnibus : TransportePublico
    {
        public override void Avanzar()
        {
            Console.WriteLine("Omnibus avanza");
        }

        public override void Detenerse()
        {
            Console.WriteLine("Omnibus se detiene");
        }
    }
}