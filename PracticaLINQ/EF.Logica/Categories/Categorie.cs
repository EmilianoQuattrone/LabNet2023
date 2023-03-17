using EF.Data;
using EF.Logica.Interfaces;
using EF.Logica.Productos.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace EF.Logica.Productos
{
    public class Categorie : IObtener<CategoriesDto>
    {
        public IEnumerable<CategoriesDto> ObtenerConsulta()
        {
            using (var context = new NorthwindContext())
            {
                var query = (from c in context.Categories
                             join p in context.Products
                             on c.CategoryID equals p.CategoryID
                             select new CategoriesDto
                             {
                                Categorias = c.CategoryName
                             }).Distinct();                          

                return query.ToList();
            }
        }
    }
}