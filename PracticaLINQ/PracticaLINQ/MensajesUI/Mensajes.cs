using EF.Entidades;
using EF.Logica.Customer;
using EF.Logica.Productos.DTOs;
using System;

namespace PracticaLINQ.MensajesUI
{
    public class Mensajes
    {
        public static void MensajeCustomer(CustomerDtos cd)
        {
            Console.WriteLine($"Id: {cd.Id} - Nombre: {cd.Nombre}");
        }

        public static void MensajeProductosSinStock(Products pd)
        {
            Console.WriteLine($"Producto: {pd.ProductName} - Sin stock: {pd.UnitsInStock}");
        }

        public static void MensajeProductoConStock(ProducrConStockDto pd)
        {
            Console.WriteLine($"Producto: {pd.Nombre} - Stock: {pd.Stock} - " +
                $"Unidades Vendidas: {pd.UnidadPrecio}");
        }

        public static void MensajeExcepcion(Exception ex)
        {
            Console.WriteLine($"Error al intentar Obtener los Customer. \n{ex}");
        }

        public static void FinDePrograma()
        {
            Console.WriteLine("Fin del programa.");
            Console.ReadLine();
        }
    }
}