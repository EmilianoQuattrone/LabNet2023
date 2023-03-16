using System;
using EF.Logica.Productos;
using PracticaLINQ.Logica;
using PracticaLINQ.Logica.Cliente;
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
            CustomerMayusculaMinusculaUI.ObtenerCustomerMayusculaMinuscula();
            Mensajes.FinDePrograma();
        }
    }
}