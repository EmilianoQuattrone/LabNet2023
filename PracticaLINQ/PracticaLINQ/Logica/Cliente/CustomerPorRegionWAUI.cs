using EF.Entidades;
using EF.Logica.Customer;
using PracticaLINQ.MensajesUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLINQ.Logica
{
    public class CustomerPorRegionWAUI
    {
        public static void ObtenerCustomerPorRegionWA()
        {
			try
			{
				CustomerPorRegionWA customerPorRegionWA = new CustomerPorRegionWA();
				var customersLista = customerPorRegionWA.ObtenerConsulta();
				ImprimirCustomerConRegionWA(customersLista);
			}
			catch (Exception ex)
			{

				Mensajes.MensajeExcepcion(ex);
			}
        }

		public static void ImprimirCustomerConRegionWA(IEnumerable<Customers> query)
		{
			foreach (var item in query)
			{
				Mensajes.MensajeCustomerConRegionWA(item);
            }
		}
    }
}