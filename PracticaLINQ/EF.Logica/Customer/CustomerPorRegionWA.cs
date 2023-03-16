﻿using EF.Data;
using EF.Entidades;
using EF.Logica.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace EF.Logica.Customer
{
    public class CustomerPorRegionWA :  IObtener<Customers>
    {
        public IEnumerable<Customers> ObtenerConsulta()
        {
            using (var context = new NorthwindContext()) 
            {
                var query = from c in context.Customers 
                            where c.Region == "WA"
                            select c;
                return query.ToList();
            }
        }
    }
}