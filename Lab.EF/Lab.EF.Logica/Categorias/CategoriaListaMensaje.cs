using Lab.EF.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logica.Categorias
{
    public class CategoriaListaMensaje
    {
        public static void ListadoCategorias(Categories item)
        {
            Console.WriteLine($"Nombre: {item.CategoryName}, Descripcion: {item.Description}");
        }
    }
}