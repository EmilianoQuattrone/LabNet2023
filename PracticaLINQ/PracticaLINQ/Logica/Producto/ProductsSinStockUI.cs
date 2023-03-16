using EF.Entidades;
using EF.Logica.Productos;
using PracticaLINQ.Funcionalidades;
using PracticaLINQ.MensajesUI;
using System;
using System.Collections.Generic;

namespace PracticaLINQ.Logica
{
    public class ProductsSinStockUI
    {
        public static void ObtenerProductosSinStock()
        {
			try
			{
                Limpiar.LimpiarConsola();
                ProductSinStock product = new ProductSinStock();
                var productsLista = product.ObtenerConsulta();
                ImprimirProductoSinStock(productsLista);
			}
			catch (Exception ex)
			{
                Mensajes.MensajeExcepcion(ex);
			}
            finally
            {
                Intentos.VolverAIntentarlo();
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