using PracticaLINQ.Funcionalidades;
using PracticaLINQ.Logica;
using PracticaLINQ.Logica.Cliente;
using PracticaLINQ.Logica.Producto;
using PracticaLINQ.MensajesUI;

namespace PracticaLINQ.MenusUI
{
    public class Menu
    {
        public static void MenuPrincipal(int opcion)
        {
            switch (opcion) 
            {
                case 1:
                    CustomersUI.ObtenerCustomers();
                    break;
                case 2:
                    ProductsSinStockUI.ObtenerProductosSinStock();
                    break;
                case 3:
                    ProductsConStockUI.ObtenerProductosConStock();
                    break;
                case 4:
                    CustomerPorRegionWAUI.ObtenerCustomerPorRegionWA();
                    break;
                case 5:
                    ProductPrimerElementoUI.ObtenerProductPrimerElemento();
                    break;
                case 6:
                    CustomerMayusculaMinusculaUI.ObtenerCustomerMayusculaMinuscula();
                    break;
                case 7:
                    CustomerOrdersUI.ObtenerCustomerOrders();
                    break;
                case 8:
                    CustomerPrimerosTresUI.ObtenerCustomerPrimerosTres();
                    break;
                case 9:
                    ProductOrdenadoProNombreUI.ObtenerProductOrdenadoProNombre();
                    break;
                case 10:
                    ProductSinStockMayorMenorUI.ObtenerProductSinStockMayorMenor();
                    break;
                case 11:
                    ProductCategoriesUI.ObtenerProductCategories();
                    break;
                case 12:
                    ProductPrimeroUI.ObtenerProductPrimero();
                    break;
                case 13:
                    CustomerCantidadOrdersUI.ObtenerCustomerCantidadOrders();
                    break;
                default:
                    Mensajes.MensajeOpcionNoValida();
                    Intentos.VolverAIntentarlo();
                    break;
            }
        }
    }
}