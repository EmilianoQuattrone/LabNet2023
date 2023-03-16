using EF.Logica.Productos;
using EF.Logica.Productos.DTOs;
using PracticaLINQ.Funcionalidades;
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
                Limpiar.LimpiarConsola();
                ProductOrdenadoProNombre productOrdenadoProNombre = new ProductOrdenadoProNombre();
                var productOrdenadoProNombreLista = productOrdenadoProNombre.ObtenerConsulta();
                ImprimirProductOrdenadoProNombre(productOrdenadoProNombreLista);
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

        public static void ImprimirProductOrdenadoProNombre(IEnumerable<ProductOrdenadoProNombreDtos> query)
        {
            foreach (var item in query) 
            {
            Mensajes.MensajeObtenerProductOrdenadoProNombre(item);
            }
        }
    }
}