using System;

namespace TrabajoPracticoN2.Clases.Consignas
{
    public class ExcepcionesPersonalizadas : Exception
    {
        public ExcepcionesPersonalizadas(string mensaje) : base(mensaje) { }
        public override string Message => "ExcepcionesPersonalizadas";
    }
}