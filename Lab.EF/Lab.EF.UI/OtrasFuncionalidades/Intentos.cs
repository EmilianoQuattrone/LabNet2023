using Lab.EF.UI.InterfazUsuario;
using Lab.EF.UI.Menus;
using Lab.EF.UI.Validaciones;
using System;

namespace Lab.EF.Logica.OtrasFuncionalidades
{
    public class Intentos
    {
        public static void VolverAIntentar()
        {
            int op = Validar.ValidarEntradasNegativasYVacias("Esta campo acepta valores numericos");
            if (op == 1)
            {
                MensajesPantalla.MenuInicio();
                int opMenu = int.Parse(Console.ReadLine());
                MenusPantalla.MenuPrincipal(opMenu);
            }
            else
            {
                MensajesPantalla.MenuFinPrograma();
            }
        }
    }
}