using Lab.EF.UI.InterfazUsuario;
using System;

namespace Lab.EF.UI.Validaciones
{
    public class Validar
    {
        public static int ValidarEntradasNegativasYVacias(string mensaje)

        {
            int valor;
            Console.WriteLine(mensaje);
            string validarNumero = Console.ReadLine();

            while (!int.TryParse(validarNumero, out valor))

            {
                Console.WriteLine(mensaje);
                validarNumero = Console.ReadLine();
            }
            return valor;
        }

        public static string IngresarValorSoloLetras(string ingreso, string nombreMensaje)
        {
            while (int.TryParse(ingreso, out int resultado) || ingreso.Trim() == "")
            {
                MensajesPantalla.MensajeSoloLetras();

                switch (nombreMensaje)
                {
                    case "Categoria":
                        MensajesPantalla.MensajeNombreCategoria();
                        break;
                    case "Descripcion":
                        MensajesPantalla.MensajeDescripcionCategoria();
                        break;
                }

                ingreso = Console.ReadLine();
            }

            return ingreso;
        }
    }
}