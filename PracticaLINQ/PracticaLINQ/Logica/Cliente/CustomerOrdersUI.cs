using EF.Logica.Customer;
using EF.Logica.Customer.DTOs;
using PracticaLINQ.MensajesUI;
using System;
using System.Collections.Generic;

namespace PracticaLINQ.Logica.Cliente
{
    public class CustomerOrdersUI
    {
        public static void ObtenerCustomerOrders()
        {
			try
			{
				CustomerOrders customerOrders = new CustomerOrders();
				var customerOrdersLista = customerOrders.ObtenerConsulta();
				ImprimirCustomerOrders(customerOrdersLista);
            }
			catch (Exception ex)
			{

				Mensajes.MensajeExcepcion(ex);
			}
        }

		public static void ImprimirCustomerOrders(IEnumerable<CustomerOrdersDtos> query)
		{
			foreach (var item in query)
			{
				Mensajes.MensajeCustomerOrders(item);
			}
		}
    }
}