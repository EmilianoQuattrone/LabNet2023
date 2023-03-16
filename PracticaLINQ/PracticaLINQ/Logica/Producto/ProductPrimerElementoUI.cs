using EF.Logica.Productos;
using PracticaLINQ.Funcionalidades;

namespace PracticaLINQ.Logica.Producto
{
    public class ProductPrimerElementoUI
    {
        public static void ObtenerProductPrimerElemento()
        {
            ProductPrimerElemento productPrimerElemento = new ProductPrimerElemento();
            productPrimerElemento.ObtenerConsulta();
            Intentos.VolverAIntentarlo();
        }
    }
}