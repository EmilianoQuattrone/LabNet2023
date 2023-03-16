using EF.Logica.Productos;
using PracticaLINQ.Funcionalidades;

namespace PracticaLINQ.Logica.Producto
{
    public class ProductPrimeroUI
    {
        public static void ObtenerProductPrimero()
        {
            Limpiar.LimpiarConsola();
            ProductPrimero.ObtenerConsulta();
            Intentos.VolverAIntentarlo();
        }
    }
}