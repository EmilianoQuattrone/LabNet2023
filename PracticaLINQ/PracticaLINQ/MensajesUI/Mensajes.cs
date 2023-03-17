using EF.Entidades;
using EF.Logica.Customer;
using EF.Logica.Customer.DTOs;
using EF.Logica.Productos.DTOs;
using PracticaLINQ.Funcionalidades;
using System;

namespace PracticaLINQ.MensajesUI
{
    public class Mensajes
    {

        public static void MensajeMenuPantalla()
        {
            Console.WriteLine("----- Menu Principal -----");
            Espacio.SaltoDeLinea();
            Console.WriteLine("1 - Mostrar todos los cliente.");
            Console.WriteLine("2 - Mostrar productos sin Stock.");
            Console.WriteLine("3 - Mostrar productos con Stock y que cuestan mas de 3 por unidad.");
            Console.WriteLine("4 - Mostrar clientes por Region = WA");
            Console.WriteLine("5 - Producto ID = 789");
            Console.WriteLine("6 - Mostrar nombres de clientes en Mayuscula y Miniscula.");
            Console.WriteLine("7 - Mostrar clientes por Region = WA y fecha mayor a 1/1/1997");
            Console.WriteLine("8 - Mostrar clientes por Region = WA, los primeros 3," );
            Console.WriteLine("9 - Mostrar productos ordenados por nombre");
            Console.WriteLine("10 - Mostrar productos ordenados por Stock vacio de Mayor a Menor.");
            Console.WriteLine("11 - Mostrar distintas categorias de los productos");
            Console.WriteLine("12 - Mostrar el primer elemento de una lista de Productos.");
            Console.WriteLine("13 - Mostrar la cantidad de clientes con ordenes asociadas");
        }
        public static void MensajeCustomer(CustomerDtos cd)
        {
            Console.WriteLine($"Nombre Cliente: {cd.Nombre}");
        }
        public static void MensajeCustomerCantidadOrders(CustomerCantidadOrdersDto cco)
        {
            Console.WriteLine($"Nombre cliente: {cco.NombreCliente} - Orden asociada: {cco.OrdenCantidad}");
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
        public static void MensajeProductosSinStock(Products pd)
        {
            Console.WriteLine($"Producto: {pd.ProductName} - Sin stock: {pd.UnitsInStock}");
        }

        public static void MensajeProductoConStock(ProducrConStockDto pd)
        {
            Console.WriteLine($"Producto: {pd.Nombre} - Stock: {pd.Stock} - " +
                $"Unidades que cuestan mas 3: {pd.UnidadPrecio}");
        }

        public static void MensajeProductSinStockMayorMenor(ProductSinStockMayorMenorDtos pmn)
        {
            Console.WriteLine($"Nombre productos: {pmn.Nombre} - Sotck: {pmn.Stock}");
        }

        public static void MensajeProductCategories(CategoriesDto pc)
        {
            Console.WriteLine($"Categorias: {pc.Categorias}.");
        }

        public static void MensajeObtenerProductOrdenadoProNombre(ProductOrdenadoProNombreDtos pon)
        {
            Console.WriteLine($"Nombre producto: {pon.NombreProducto}");
        }

        public static void MensajeExcepcion(Exception ex)
        {
            Console.WriteLine($"Error al intentar Obtener los Customer. \n{ex}");
        }

        public static void MensajeOpcionNoValida()
        {
            Console.WriteLine("Opcion no valida.");
        }

        public static void MensajeVolverAIntentarlo()
        {
            Console.WriteLine("¿Volver a intentarlo?" +
                "\nPresione 1 para SI" + "\nPresione cualquier NUMERO para salir.");
        }
        public static void FinDePrograma()
        {
            Console.WriteLine("Fin del programa.");
            Console.ReadLine();
        }
    }
}