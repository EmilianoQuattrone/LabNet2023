﻿using Lab.EF.UI.InterfazUsuario;
using Lab.EF.UI.OtrasFuncionalidades;
using System;
using System.Text.RegularExpressions;

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
            Regex regex = new Regex("^[a-zA-Z]*$");

            while (!regex.IsMatch(ingreso) || ingreso.Trim() == "")
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

                ingreso = Ingreso.IngresoUsuario();
            }

            return ingreso;
        }
    }
}