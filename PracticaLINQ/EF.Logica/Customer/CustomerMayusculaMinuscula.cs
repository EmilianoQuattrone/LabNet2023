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
    public class CustomerMayusculaMinuscula : IObtener<CustomerMayusculaMinusculaDtos>
    {
        public IEnumerable<CustomerMayusculaMinusculaDtos> ObtenerConsulta()
        {
            using (var contex = new NorthwindContext()) 
            {
                return contex.Customers.
                    Select(c => new CustomerMayusculaMinusculaDtos
                {
                    Mayuscula = c.ContactName.ToUpper(),
                    Minuscula = c.ContactName.ToLower()
                }).ToList();
            }
        }
    }
}