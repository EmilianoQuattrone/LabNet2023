using Lab.EF.Entidades;
using Lab.EF.Logica.OtrasFuncionalidades;
using Lab.EF.UI.InterfazUsuario;
using Lab.EF.UI.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.UI.Menus
{
    public class MenusPantalla
    {
        public static void MenuPrincipal(int opcion)
        {
            switch (opcion)
            {
                case 0:

                    break;
                case 1:
                    MensajesPantalla.MensajeEmpleados();
                    Empleados.ObtenerEmpleados();
                    break;
                case 2:
                    MensajesPantalla.MensajeCategorias();
                    Categorias.ObtenerCategorias();
                    break;
                case 3:
                    MensajesPantalla.MensajeIngreseCategoria();
                    MensajesPantalla.MensajeIdCategoria();                   
                    Categorias.IngresarCategoria(OtrosMenus.MenuCategoria());
                    break;
                case 4:

                    break;
                case 5:

                    break;

                default:
                    MensajesPantalla.MensajeDefaul();
                    MensajesPantalla.VolverAIntentarlo();
                    Intentos.VolverAIntentar();
                    break;
            }
        }
    }
}
