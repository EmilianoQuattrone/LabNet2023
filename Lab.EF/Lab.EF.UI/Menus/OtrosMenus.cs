using Lab.EF.Entidades;
using Lab.EF.UI.InterfazUsuario;
using Lab.EF.UI.Logica;
using Lab.EF.UI.Validaciones;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

namespace Lab.EF.UI.Menus
{
    public class OtrosMenus
    {
        public static Categories MenuIngresarCategoria()
        {
            MensajesPantalla.MensajeIdCategoria();
            int idCategoria = Validar.ValidarEntradasNegativasYVacias("Esta campo acepta valores numericos");
            MensajesPantalla.MensajeNombreCategoria();
            string nombreCategoria = Validar.IngresarValorSoloLetras(Console.ReadLine(), "Categoria");

            MensajesPantalla.MensajeDescripcionCategoria();
            string descripcionCategoria = Validar.IngresarValorSoloLetras(Console.ReadLine(), "Descripcion");

            Categories categories = new Categories
            {
                CategoryID = idCategoria,
                CategoryName = nombreCategoria,
                Description = descripcionCategoria
            };

            return categories;
        }

        public static Categories MenuModificarCategoria()
        {
            MensajesPantalla.MensajeIdCategoria();
            int idCategoria = Validar.ValidarEntradasNegativasYVacias("Esta campo acepta valores numericos");

            MensajesPantalla.MensajeNombreCategoria();
            string nombreCategoria = Validar.IngresarValorSoloLetras(Console.ReadLine(), "Categoria");

            MensajesPantalla.MensajeDescripcionCategoria();
            string descripcionCategoria = Validar.IngresarValorSoloLetras(Console.ReadLine(), "Descripcion");

            Categories categories = new Categories
            {
                CategoryID = idCategoria,
                CategoryName = nombreCategoria,
                Description = descripcionCategoria
            };

            return categories;
        }

        public static int MenuEliminarCategoria()
        {
            MensajesPantalla.MensajeIdCategoria();
            int idCategoria = Validar.ValidarEntradasNegativasYVacias("Esta campo acepta valores numericos");
            return idCategoria;
        }
    }
}