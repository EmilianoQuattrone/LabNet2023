using EF.Logica.Customer;
using EF.Logica.Customer.DTOs;
using PracticaLINQ.Funcionalidades;
using PracticaLINQ.MensajesUI;
using System;
using System.Collections;
using System.Collections.Generic;

namespace PracticaLINQ.Logica.Cliente
{
    internal class CustomerPrimerosTresUI
    {
        public static void ObtenerCustomerPrimerosTres()
        {
			try
			{
				CustomerPrimerosTres customerPrimerosTres = new CustomerPrimerosTres();
				var customerPrimerosTresLista = customerPrimerosTres.ObtenerConsulta();
				ImprimirCustomerPrimerosTres(customerPrimerosTresLista);
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

		public static void ImprimirCustomerPrimerosTres(IEnumerable<CustomerPrimerosTresDtos> query)
		{
			foreach (var item in query)
			{
				Mensajes.MensajeCustomerPrimerosTres(item);

            }
		}
    }
}