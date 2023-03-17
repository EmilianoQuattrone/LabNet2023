using EF.Data;
using EF.Logica.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace EF.Logica.Customer
{
    public class CustomerCompleto : IObtener<CustomerDtos>
    {
        public IEnumerable<CustomerDtos> ObtenerConsulta()
        {
            using (var context = new NorthwindContext())

            {
                return context.Customers
                       .Take(5)
                       .Select(c => new CustomerDtos
                       {
                           Id = c.CustomerID,
                           Nombre = c.CompanyName
                       }).ToList();
            }
        }
    }
}