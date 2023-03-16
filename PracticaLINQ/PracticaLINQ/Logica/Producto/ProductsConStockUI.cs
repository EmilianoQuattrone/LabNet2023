using EF.Logica.Productos;
using EF.Logica.Productos.DTOs;
using PracticaLINQ.MensajesUI;
using System;
using System.Collections.Generic;

namespace PracticaLINQ.Logica
{
    public class ProductsConStockUI
    {
        public static void ObtenerProductosConStock()
        {
			try
			{
				ProducrConStock producrConStock = new ProducrConStock();
				var productsLista = producrConStock.ObtenerConsulta();
				ImprimirProductoConStock(productsLista);
			}
			catch (Exception ex)
			{
				Mensajes.MensajeExcepcion(ex);
			}
        }

		public static void ImprimirProductoConStock(IEnumerable<ProducrConStockDto> query)
		{
			foreach (var item in query)
			{
				Mensajes.MensajeProductoConStock(item);
			}
		}
    }
}