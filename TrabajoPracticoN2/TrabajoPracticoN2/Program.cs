using TrabajoPracticoN2.Clases;
using TrabajoPracticoN2.Validaciones;

namespace TrabajoPracticoN2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mensajes.MensajesConsola();
            decimal opcionIngresada = Validar.ValidarEntradasNegativasYVacias("Ingrese solo numeros: ");
            Menu.MenuUsuario(opcionIngresada);
            Mensajes.MensajeFinDePrograma();
        }
    }
}