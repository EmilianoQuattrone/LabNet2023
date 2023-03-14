using Lab.EF.Data;
using Lab.EF.Entidades;
using Lab.EF.Logica.Categorias;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Lab.EF.Logica
{
    public class CategoriasLogica : NorthwindLogica, ICRUD<Categories>
    {
        public CategoriasLogica() { }

        public CategoriasLogica(NorthwindContext context) 
        {
            northwindContext = context;
        }

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
            var modificarCategoria = northwindContext.Categories.First(c => c.CategoryID == categorias.CategoryID);
            modificarCategoria.CategoryID = categorias.CategoryID;
            modificarCategoria.CategoryName = categorias.CategoryName;
            modificarCategoria.Description = categorias.Description;
            northwindContext.SaveChanges();                    
        }

        public void Eliminar(int id)
        {
            var eliminarCategoria = northwindContext.Categories.Find(id);
            northwindContext.Categories.Remove(eliminarCategoria);
            northwindContext.SaveChanges();         
        }
    }
}