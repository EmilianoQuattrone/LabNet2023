using Lab.EF.UI.InterfazUsuario;
using Lab.EF.UI.Menus;
using Lab.EF.UI.OtrasFuncionalidades;
using Lab.EF.UI.Validaciones;

namespace Lab.EF.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MensajesPantalla.MenuInicio();
            int opcion = Ingreso.IngresoUsuarioSoloNumeros();
            MenusPantalla.MenuPrincipal(opcion);
        }
    }
}