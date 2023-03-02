using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoN1.Clases
{
    public abstract class TransportePublico
    {
        public int Pasajeros { set; get; }

        public abstract void Avanzar();
        public abstract void Detenerse();
    }
}