using EF.Data;
using EF.Entidades;
using EF.Logica.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Logica.Productos
{
    public class Product : IObtener<Products>
    {
        public IEnumerable<Products> ObtenerTodo()
        {
            using (var context = new NorthwindContext())
            {
                var query = from p in context.Products
                            where p.UnitsInStock == 0
                            select p;
                return query.ToList();
            }
        }
    }
}