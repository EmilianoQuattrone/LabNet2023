using EF.Data;
using EF.Logica.Interfaces;
using EF.Logica.Productos.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace EF.Logica.Productos
{
    public class ProductCategories : IObtener<ProductCategoriesDto>
    {
        public IEnumerable<ProductCategoriesDto> ObtenerConsulta()
        {
            using (var context = new NorthwindContext())
            {
                var query = from p in context.Products
                            join c in context.Categories
                            on p.CategoryID equals c.CategoryID
                            where c.CategoryName != null
                            orderby p.ProductName
                            select new ProductCategoriesDto
                            {
                                Categorias = c.CategoryName,
                                NombreProducto = p.ProductName
                            };

                return query.ToList();
            }
        }
    }
}