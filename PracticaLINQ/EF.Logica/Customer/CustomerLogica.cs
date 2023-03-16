using EF.Data;
using EF.Entidades;
using EF.Logica.Context;
using EF.Logica.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace EF.Logica.Customer
{
    public class CustomerLogica : Northwind, IObtener<CustomerDtos>
    {
        public IEnumerable<CustomerDtos> ObtenerTodo()
        {
            using (var context = new NorthwindContext())

            {
                return context.Customers
                       .Select(c => new CustomerDtos
                       {
                           Id = c.CustomerID,
                           Nombre = c.CompanyName
                       }).ToList();
            }
        }
    }
}