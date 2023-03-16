using System;
using EF.Logica.Productos;
using PracticaLINQ.Logica;
using PracticaLINQ.MensajesUI;

namespace PracticaLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CustomersUI.ObtenerCustomers();
            ProductsUI.ObtenerPRoductosSinStock();
            Mensajes.FinDePrograma();
        }
    }
}