using EF.Data;
using EF.Logica.Interfaces;
using EF.Logica.Productos.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace EF.Logica.Productos
{
    public class ProductOrdenadoProNombre : IObtener<ProductOrdenadoProNombreDtos>
    {
        public IEnumerable<ProductOrdenadoProNombreDtos> ObtenerConsulta()
        {
            using (var context = new NorthwindContext())
            {
                return context.Products
                    .Select(p => new ProductOrdenadoProNombreDtos 
                    
                    {
                        NombreProducto = p.ProductName
                    })
                    .OrderBy(p => p.NombreProducto)
                    .ToList();
            }
        }
    }
}