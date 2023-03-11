using Lab.EF.UI.InterfazUsuario;
using Lab.EF.UI.Menus;
using Lab.EF.UI.Validaciones;

namespace Lab.EF.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MensajesPantalla.MenuInicio();
            int opcion = Validar.ValidarEntradasNegativasYVacias("Aqui solo ingresar numeros");
            MenusPantalla.MenuPrincipal(opcion);
            MensajesPantalla.MenuFinPrograma();
        }
    }
}