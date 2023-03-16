using EF.Entidades;
using System;

namespace EF.Logica.Productos.Mensaje
{
    public class ProductMensaje
    {
        public static void MensajeProductExiste(Products products)
        {
            Console.WriteLine($"Nombre: {products.ProductName}");
        }
        public static void MensajeProductNoExite()
        {
            Console.WriteLine("El producto no existe");
        }
    }
}