using Lab.EF.UI.InterfazUsuario;
using Lab.EF.UI.Menus;
using Lab.EF.UI.OtrasFuncionalidades;
using Lab.EF.UI.Validaciones;

namespace Lab.EF.Logica.OtrasFuncionalidades
{
    public class Intentos
    {
        public static void VolverAIntentar()
        {
            Espacios.SaltoLinea();
            MensajesPantalla.VolverAIntentarlo();
            int op = Ingreso.IngresoUsuarioSoloNumeros();
            if (op == 1)
            {
                LimpiarPantalla.Limpiar();
                MensajesPantalla.MenuInicio();
                int opMenu = Ingreso.IngresoUsuarioSoloNumeros();
                MenusPantalla.MenuPrincipal(opMenu);
            }
            else
            {
                MensajesPantalla.MenuFinPrograma();
            }
        }
    }
}