using EF.Logica.Productos;
using EF.Logica.Productos.DTOs;
using PracticaLINQ.MensajesUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLINQ.Logica.Producto
{
    public class ProductCategoriesUI
    {
        public static void ObtenerProductCategories()
        {
			try
			{
				ProductCategories productCategories = new ProductCategories();
				var productCategoriesLista = productCategories.ObtenerConsulta();
                ImprimirProductCategories(productCategoriesLista);

            }
			catch (Exception ex)
			{
                Mensajes.MensajeExcepcion(ex);
			}
        }

        public static void ImprimirProductCategories(IEnumerable<ProductCategoriesDto> query)
        {
            foreach (var item in query) 
            {
                Mensajes.MensajeProductCategories(item);
            }
        }
    }
}
