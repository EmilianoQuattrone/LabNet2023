using EF.Data;
using EF.Logica.Customer.DTOs;
using EF.Logica.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EF.Logica.Customer
{
    public class CustomerOrders : IObtener<CustomerOrdersDtos>
    {
        public IEnumerable<CustomerOrdersDtos> ObtenerConsulta()
        {
            DateTime fechaOrden = new DateTime(1997, 1, 1);

            using (var context = new NorthwindContext()) 
            {
                var query = from c in context.Customers
                            where c.Region == "WA"                       
                            join o in context.Orders                    
                            on c.CustomerID equals o.CustomerID
                            where o.OrderDate > fechaOrden
                            orderby o.OrderDate 
                            select new CustomerOrdersDtos 
                            {
                                NombreCliente = c.ContactName,
                                Region = c.Region,
                                OrdenFecha = (DateTime)o.OrderDate
                            };
                return query.ToList();
            }
        }
    }
}