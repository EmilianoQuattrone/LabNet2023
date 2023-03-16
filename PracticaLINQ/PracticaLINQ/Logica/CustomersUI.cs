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
                CustomerLogica customerLogica = new CustomerLogica();
                IEnumerable<CustomerDtos> customersLista = customerLogica.ObtenerTodo();
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