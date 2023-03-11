using Lab.EF.Entidades;
using System;

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