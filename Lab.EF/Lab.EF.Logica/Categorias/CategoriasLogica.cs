using Lab.EF.Data;
using Lab.EF.Entidades;
using Lab.EF.Logica.Categorias;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab.EF.Logica
{
    public class CategoriasLogica : NorthwindLogica, ICRUD<CategoriasDto>
    {
        public CategoriasLogica() { }

        public CategoriasLogica(NorthwindContext context) 
        {
            northwindContext = context;
        }

        public List<CategoriasDto> ObtenerTodos()
        {
            using (var context = new NorthwindContext())
            {
                return context.Categories.Select(c => new CategoriasDto
                {
                    Id = c.CategoryID,
                    Nombre = c.CategoryName,
                    Descripcion = c.Description
                }).ToList();
            }
        }

        public void Add(CategoriasDto dto)
        {
            using (var context = new NorthwindContext())
            {
                var nuevaCategoria = new Categories()
                {
                    CategoryName = dto.Nombre,
                    Description = dto.Descripcion
                };
                context.Categories.Add(nuevaCategoria);
                context.SaveChanges();
            }
        }

        public void Modificar(CategoriasDto dto)
        {
            using (var context = new NorthwindContext())
            {
                var categoriaModificada = context.Categories.FirstOrDefault(c => c.CategoryID == dto.Id);
                if (categoriaModificada == null)
                {
                    throw new Exception("El empleado no se encontro");
                }

                categoriaModificada.CategoryName = dto.Nombre;
                categoriaModificada.Description = dto.Descripcion;
                context.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {

            using (var context = new NorthwindContext())
            {
                var eliminarCategoria = context.Categories.FirstOrDefault(c => c.CategoryID == id);
                context.Categories.Remove(eliminarCategoria);
                context.SaveChanges();
            }
        }
    }
}