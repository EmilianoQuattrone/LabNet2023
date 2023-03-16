using EF.Data;
using EF.Logica.Customer.DTOs;
using EF.Logica.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Logica.Customer
{
    public class CustomerCantidadOrders : IObtener<CustomerCantidadOrdersDto>
    {
        public IEnumerable<CustomerCantidadOrdersDto> ObtenerConsulta()
        {
            using (var context = new NorthwindContext())
            {
                var query = from c in context.Customers
                            join o in context.Orders
                            on c.CustomerID equals o.CustomerID
                            orderby c.CustomerID ascending
                            select new CustomerCantidadOrdersDto
                            {
                                NombreCliente = c.ContactName,
                                NombreOrden = o.ShipName,
                            };

                return query.ToList();
            }
        }
    }
}