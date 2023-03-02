using System;

namespace TrabajoPracticoN1.Clases
{
    public class Taxi : TransportePublico
    {
        public override void Avanzar()
        {
            Console.WriteLine("Taxi avanza");
        }

        public override void Detenerse()
        {
            Console.WriteLine("Taxi se detiene");
        }
    }
}