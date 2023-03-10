using Lab.EF.Data;
using Lab.EF.Entidades;
using Lab.EF.Logica.Categorias;
using Lab.EF.Logica.Excepciones;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;

namespace Lab.EF.Logica
{
    public class CategoriasLogica : NorthwindLogica, ICRUD<Categories>
    {
        public List<Categories> ObtenerTodos()
        {
            return northwindContext.Categories.ToList();
        }

        public void ListarCategorias()
        {
            foreach (var item in ObtenerTodos())
            {
                CategoriaListaMensaje.ListadoCategorias(item);
            }
        }

        public void Add(Categories categoria)
        {
            northwindContext.Categories.Add(categoria);
            northwindContext.SaveChanges();
        }

        public void Modificar(Categories categorias)
        {
            try
            {
                var modificarCategoria = northwindContext.Categories.Find(categorias.CategoryID);
                modificarCategoria.CategoryName = categorias.CategoryName;
                northwindContext.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                var eliminarCategoria = northwindContext.Categories.Find(id);
                northwindContext.Categories.Remove(eliminarCategoria);
                northwindContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }            
        }
    }
}