using PracticaLINQ.Funcionalidades;
using PracticaLINQ.MensajesUI;
using PracticaLINQ.MenusUI;

namespace PracticaLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mensajes.MensajeMenuPantalla();
            Menu.MenuPrincipal(IngresoUsuario.IngresoUsuarioSoloNumeros());
        }
    }
}