using EF.Data;
using EF.Logica.Interfaces;
using EF.Logica.Productos.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace EF.Logica.Productos
{
    public class ProducrConStock : IObtener<ProducrConStockDto>
    {
        public IEnumerable<ProducrConStockDto> ObtenerConsulta()
        {
            using (var context = new NorthwindContext())
            {
                return context.Products
                    .Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3)
                    .Select(p => new ProducrConStockDto 
                    {
                        Nombre = p.ProductName,
                        Stock = (short)p.UnitsInStock,
                        UnidadPrecio = (decimal)p.UnitPrice
                    }).ToList();
            }
        }
    }
}