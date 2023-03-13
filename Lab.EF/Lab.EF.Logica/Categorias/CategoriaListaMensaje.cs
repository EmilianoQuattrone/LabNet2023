using Lab.EF.Entidades;
using System;

namespace Lab.EF.Logica.Categorias
{
    public class CategoriaListaMensaje
    {
        public static void ListadoCategorias(Categories item)
        {
            Console.WriteLine($"ID: {item.CategoryID} - Nombre: {item.CategoryName} - Descripcion: {item.Description}");
        }
    }
}