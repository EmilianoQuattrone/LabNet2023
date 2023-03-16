using EF.Logica.Customer;
using PracticaLINQ.MensajesUI;
using System;
using System.Collections.Generic;

namespace PracticaLINQ.Logica
{
    public class CustomersUI
    {
        public static void ObtenerCustomers()
        {
            try 
            {
                CustomerCompleto customerLogica = new CustomerCompleto();
                var customersLista = customerLogica.ObtenerConsulta();
                ImprimirCustomer(customersLista);
            }
            catch (Exception ex) 
            {
                Mensajes.MensajeExcepcion(ex);   
            }              
        }

        public static void ImprimirCustomer(IEnumerable<CustomerDtos> query)
        {
            foreach (var item in query)
            {
                Mensajes.MensajeCustomer(item);
            }
        }
    }
}