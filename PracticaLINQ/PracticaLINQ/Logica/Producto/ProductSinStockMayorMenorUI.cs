using EF.Logica.Productos;
using EF.Logica.Productos.DTOs;
using PracticaLINQ.Funcionalidades;
using PracticaLINQ.MensajesUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLINQ.Logica.Producto
{
    public class ProductSinStockMayorMenorUI
    {
        public static void ObtenerProductSinStockMayorMenor()
        {
			try
			{
                Limpiar.LimpiarConsola();
                ProductSinStockMayorMenor productSinStockMayorMenor = new ProductSinStockMayorMenor();
                var productSinStockMayorMenorLista = productSinStockMayorMenor.ObtenerConsulta();
                ImprimerProductSinStockMayorMenor(productSinStockMayorMenorLista);
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

        public static void ImprimerProductSinStockMayorMenor(IEnumerable<ProductSinStockMayorMenorDtos> query)
        {
            foreach (var item in query) 
            {
                Mensajes.MensajeProductSinStockMayorMenor(item);
            }
        }
    }
}