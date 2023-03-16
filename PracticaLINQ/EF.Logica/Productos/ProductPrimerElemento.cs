using EF.Data;
using EF.Logica.Productos.Mensaje;
using System.Linq;

namespace EF.Logica.Productos
{
    public class ProductPrimerElemento 
    {
        public bool ObtenerConsulta()
        {
            using (var context = new NorthwindContext())
            {
                var query =  context.Products.FirstOrDefault(p => p.ProductID == 789);
            
                if (query != null)
                {
                    ProductMensaje.MensajeProductExiste(query);
                    return true;
                }
                else
                {
                    ProductMensaje.MensajeProductNoExite();
                    return false;
                }
            }
        }
    }
}