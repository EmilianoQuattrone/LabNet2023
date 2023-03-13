using Lab.EF.UI.Validaciones;
using System;

namespace Lab.EF.UI.OtrasFuncionalidades
{
    public class Ingreso
    {
        public static string IngresoUsuario()
        {
            string ingreso;
            ingreso = Console.ReadLine();
            return ingreso;
        }
        public static int IngresoUsuarioSoloNumeros()
        {
            int ingreso = Validar.ValidarEntradasNegativasYVacias("Esta campo acepta valores numericos");
            return ingreso;
        }
    }
}