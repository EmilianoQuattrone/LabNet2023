using PracticaLINQ.MensajesUI;
using PracticaLINQ.MenusUI;

namespace PracticaLINQ.Funcionalidades
{
    public class Intentos
    {
        public static void VolverAIntentarlo()
        {
            Espacio.SaltoDeLinea();
            Mensajes.MensajeVolverAIntentarlo();
            int op = IngresoUsuario.IngresoUsuarioSoloNumeros();

            if (op == 1)
            {
                Limpiar.LimpiarConsola();
                Mensajes.MensajeMenuPantalla();
                int opcion = IngresoUsuario.IngresoUsuarioSoloNumeros();
                Menu.MenuPrincipal(opcion);
            }
            else
            {
                Mensajes.FinDePrograma();
            }
        }
    }
}