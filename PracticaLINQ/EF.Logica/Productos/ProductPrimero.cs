using EF.Data;
using EF.Entidades;
using EF.Logica.Productos.Mensaje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Logica.Productos
{
    public class ProductPrimero
    {
        public static void ObtenerConsulta()
        {
            using (var context = new NorthwindContext())
            {
                var query = context.Products.First();
                ProductMensaje.MensajeProdcutoPrimero(query);
            }
        }
    }
}