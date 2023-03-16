using EF.Entidades;
using EF.Logica.Productos;
using PracticaLINQ.MensajesUI;
using System;
using System.Collections.Generic;

namespace PracticaLINQ.Logica
{
    public class ProductsUI
    {
        public static void ObtenerPRoductosSinStock()
        {
			try
			{
                Product product = new Product();
                IEnumerable<Products> productsLista = product.ObtenerTodo();
                ImprimirProductoSinStock(productsLista);
			}
			catch (Exception ex)
			{
                Mensajes.MensajeExcepcion(ex);
			}
        }

        public static void ImprimirProductoSinStock(IEnumerable<Products> query)
        {
            foreach (var item in query) 
            {
                Mensajes.MensajeProductosSinStock(item);
            }
        } 
    }
}