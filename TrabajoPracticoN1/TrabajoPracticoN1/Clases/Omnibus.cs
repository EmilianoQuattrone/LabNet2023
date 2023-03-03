using System;

namespace TrabajoPracticoN1.Clases
{
    public class Omnibus : TransportePublico
    {
        public override void Avanzar()
        {
            Console.WriteLine("Todos los Omnibus cargados avanzan");
        }

        public override void Detenerse()
        {
            Console.WriteLine("Omnibus se detiene");
        }
    }
}