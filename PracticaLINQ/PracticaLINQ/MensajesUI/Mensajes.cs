using EF.Entidades;
using EF.Logica.Customer;
using EF.Logica.Customer.DTOs;
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

        public static void MensajeProductSinStockMayorMenor(ProductSinStockMayorMenorDtos pmn)
        {
            Console.WriteLine($"Nombre productos: {pmn.Nombre} - Sotck: {pmn.Stock}");
        }

        public static void MensajeProductCategories(ProductCategoriesDto pc)
        {
            Console.WriteLine($"Nombre producto: {pc.NombreProducto} - Categorias: {pc.Categorias}");
        }

        public static void MensajeObtenerProductOrdenadoProNombre(ProductOrdenadoProNombreDtos pon)
        {
            Console.WriteLine($"Nombre producto: {pon.NombreProducto}");
        }

        public static void MensajeCustomerCantidadOrders(CustomerCantidadOrdersDto cco)
        {
            Console.WriteLine($"Nombre cliente: {cco.NombreCliente} - Orden asociada: {cco.NombreOrden}");
        }
        public static void MensajeCustomerPrimerosTres(CustomerPrimerosTresDtos cpt)
        {
            Console.WriteLine($"Nombre: {cpt.Nombre} - Region: {cpt.Region}");
        }

        public static void MensajeCustomerConRegionWA(Customers cs)
        {
            Console.WriteLine($"Nombre: {cs.ContactName} - Region: {cs.Region}");
        }

        public static void MensajeCustomerMayusculaMinuscula(CustomerMayusculaMinusculaDtos cmn)
        {
            Console.WriteLine($"Nombre en Mayuscula: {cmn.Mayuscula} - Nombre en Miniscula: {cmn.Minuscula}");
        }

        public static void MensajeCustomerOrders(CustomerOrdersDtos co)
        {
            Console.WriteLine($"Nombre: {co.NombreCliente} - Region: {co.Region} - Fecha: {co.OrdenFecha}");
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