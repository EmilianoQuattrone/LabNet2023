using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoN2.Clases.Consignas
{
    public class ExcepcionesPersonalizadas : Exception
    {
        public ExcepcionesPersonalizadas(string mensaje) : base(mensaje) { }
    }
}