using EF.Logica.Productos;
using EF.Logica.Productos.DTOs;
using PracticaLINQ.Funcionalidades;
using PracticaLINQ.MensajesUI;
using System;
using System.Collections.Generic;

namespace PracticaLINQ.Logica.Producto
{
    public class ProductCategoriesUI
    {
        public static void ObtenerProductCategories()
        {
			try
			{
                Limpiar.LimpiarConsola();
                Categorie productCategories = new Categorie();
				var productCategoriesLista = productCategories.ObtenerConsulta();
                ImprimirProductCategories(productCategoriesLista);

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

        public static void ImprimirProductCategories(IEnumerable<CategoriesDto> query)
        {
            foreach (var item in query) 
            {
                Mensajes.MensajeProductCategories(item);
            }
        }
    }
}