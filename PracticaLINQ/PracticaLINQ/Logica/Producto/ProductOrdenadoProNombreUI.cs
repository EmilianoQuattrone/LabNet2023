using EF.Logica.Productos;
using EF.Logica.Productos.DTOs;
using PracticaLINQ.MensajesUI;
using System;
using System.Collections.Generic;

namespace PracticaLINQ.Logica.Producto
{
    public class ProductOrdenadoProNombreUI
    {
        public static void ObtenerProductOrdenadoProNombre()
        {
			try
			{
                ProductOrdenadoProNombre productOrdenadoProNombre = new ProductOrdenadoProNombre();
                var productOrdenadoProNombreLista = productOrdenadoProNombre.ObtenerConsulta();
                ImprimirProductOrdenadoProNombre(productOrdenadoProNombreLista);
            }
			catch (Exception ex)
			{
                Mensajes.MensajeExcepcion(ex);
			}
        }

        public static void ImprimirProductOrdenadoProNombre(IEnumerable<ProductOrdenadoProNombreDtos> query)
        {
            foreach (var item in query) 
            {
            Mensajes.MensajeObtenerProductOrdenadoProNombre(item);
            }
        }
    }
}