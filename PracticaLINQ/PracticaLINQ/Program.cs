using System;
using EF.Logica.Customer;
using EF.Logica.Productos;
using PracticaLINQ.Funcionalidades;
using PracticaLINQ.Logica;
using PracticaLINQ.Logica.Cliente;
using PracticaLINQ.Logica.Producto;
using PracticaLINQ.MensajesUI;
using PracticaLINQ.MenusUI;

namespace PracticaLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mensajes.MensajeMenuPantalla();
            Menu.MenuPrincipal(IngresoUsuario.IngresoUsuarioSoloNumeros());
            Mensajes.FinDePrograma();
        }
    }
}