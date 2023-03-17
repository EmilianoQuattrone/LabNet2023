using EF.Logica.Customer;
using EF.Logica.Customer.DTOs;
using PracticaLINQ.Funcionalidades;
using PracticaLINQ.MensajesUI;
using System;
using System.Collections.Generic;

namespace PracticaLINQ.Logica.Cliente
{
    public class CustomerCantidadOrdersUI
    {
        public static void ObtenerCustomerCantidadOrders()
        {
            try
            {
                Limpiar.LimpiarConsola();
                CustomerCantidadOrders customerCantidadOrders = new CustomerCantidadOrders();
                var customerCantidadOrdersLista = customerCantidadOrders.ObtenerConsulta();
                ImprimirCustomerCantidadOrders(customerCantidadOrdersLista);
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

        public static void ImprimirCustomerCantidadOrders(IEnumerable<CustomerCantidadOrdersDto> query)
        {
            foreach (var item in query)
            {
                Mensajes.MensajeCustomerCantidadOrders(item);
            }
        }
    }
}