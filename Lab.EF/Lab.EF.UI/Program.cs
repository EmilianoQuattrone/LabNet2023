using Lab.EF.Entidades;
using Lab.EF.Logica;
using Lab.EF.UI.InterfazUsuario;
using Lab.EF.UI.Menus;
using Lab.EF.UI.Validaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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