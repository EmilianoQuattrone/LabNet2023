using EF.Data;
using EF.Logica.Interfaces;
using EF.Logica.Productos.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace EF.Logica.Productos
{
    public class ProductSinStockMayorMenor : IObtener<ProductSinStockMayorMenorDtos>
    {
        public IEnumerable<ProductSinStockMayorMenorDtos> ObtenerConsulta()
        {
            using (var context = new NorthwindContext())
            {
                var query = from p in context.Products
                            orderby p.UnitsInStock descending
                            select new ProductSinStockMayorMenorDtos
                            
                            {
                                Nombre = p.ProductName,
                                Stock = (short)p.UnitsInStock
                            };
                return query.ToList();
            }
        }
    }
}