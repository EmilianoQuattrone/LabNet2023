using System;
using EF.Logica.Customer;
using EF.Logica.Productos;
using PracticaLINQ.Logica;
using PracticaLINQ.Logica.Cliente;
using PracticaLINQ.Logica.Producto;
using PracticaLINQ.MensajesUI;

namespace PracticaLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CustomersUI.ObtenerCustomers();
            //ProductsSinStockUI.ObtenerPRoductosSinStock();
            //ProductsConStockUI.ObtenerProductosConStock();
            //CustomerPorRegionWAUI.ObtenerCustomerPorRegionWA();
            //CustomerMayusculaMinusculaUI.ObtenerCustomerMayusculaMinuscula();
            //CustomerOrdersUI.ObtenerCustomerOrders();
            //ProductPrimerElementoUI.ObtenerProductPrimerElemento();
            //CustomerPrimerosTresUI.ObtenerCustomerPrimerosTres();
            //ProductOrdenadoProNombreUI.ObtenerProductOrdenadoProNombre();
            ProductSinStockMayorMenorUI.ObtenerProductSinStockMayorMenor();
            Mensajes.FinDePrograma();
        }
    }
}