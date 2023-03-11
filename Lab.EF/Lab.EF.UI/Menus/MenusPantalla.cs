using Lab.EF.Logica.OtrasFuncionalidades;
using Lab.EF.UI.InterfazUsuario;
using Lab.EF.UI.Logica;

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
                    Categorias.IngresarCategoria(OtrosMenus.MenuIngresarCategoria());
                    break;
                case 4:
                    MensajesPantalla.MensajeCategoriaModificacion();
                    Categorias.ModificarCategoria(OtrosMenus.MenuModificarCategoria());
                    break;
                case 5:
                    MensajesPantalla.MensajeCategoriaEliminar();
                    Categorias.EliminarCategoria(OtrosMenus.MenuEliminarCategoria());
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