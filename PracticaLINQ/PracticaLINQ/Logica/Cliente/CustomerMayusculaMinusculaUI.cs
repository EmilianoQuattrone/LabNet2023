using EF.Logica.Customer;
using EF.Logica.Customer.DTOs;
using PracticaLINQ.Funcionalidades;
using PracticaLINQ.MensajesUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLINQ.Logica.Cliente
{
    public class CustomerMayusculaMinusculaUI
    {
        public static void ObtenerCustomerMayusculaMinuscula()
        {
			try
			{
                Limpiar.LimpiarConsola();
                CustomerMayusculaMinuscula customerMayusculaMinuscula = new CustomerMayusculaMinuscula();
				var customerLista = customerMayusculaMinuscula.ObtenerConsulta();
				ImprimirCustomerMayusculaMinuscula(customerLista);
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

		public static void ImprimirCustomerMayusculaMinuscula(IEnumerable<CustomerMayusculaMinusculaDtos> query)
		{
			foreach (var item in query)
			{
				Mensajes.MensajeCustomerMayusculaMinuscula(item);
			}
		}
    }
}
