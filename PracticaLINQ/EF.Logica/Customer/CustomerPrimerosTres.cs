using EF.Data;
using EF.Logica.Customer.DTOs;
using EF.Logica.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace EF.Logica.Customer
{
    public class CustomerPrimerosTres : IObtener<CustomerPrimerosTresDtos>
    {
        public IEnumerable<CustomerPrimerosTresDtos> ObtenerConsulta()
        {
            string regionWA = "WA";
            using (var context = new NorthwindContext()) 
            {
                return context.Customers
                    .Where(r => r.Region == regionWA)
                    .Take(3)
                    .Select(c => new CustomerPrimerosTresDtos
                    {
                        Nombre = c.ContactName,
                        Region = c.Region
                    }).ToList();
            }
        }
    }
}