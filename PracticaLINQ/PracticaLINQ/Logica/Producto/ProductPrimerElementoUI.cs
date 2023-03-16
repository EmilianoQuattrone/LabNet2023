using EF.Logica.Productos;

namespace PracticaLINQ.Logica.Producto
{
    public class ProductPrimerElementoUI
    {
        public static void ObtenerProductPrimerElemento()
        {
            ProductPrimerElemento productPrimerElemento = new ProductPrimerElemento();
            productPrimerElemento.ObtenerConsulta();
        }
    }
}