using Lab.EF.Entidades;
using Lab.EF.Logica.OtrasFuncionalidades;
using Lab.EF.UI.InterfazUsuario;
using Lab.EF.UI.OtrasFuncionalidades;
using Lab.EF.UI.Validaciones;
using System;

namespace Lab.EF.UI.Menus
{
    public class OtrosMenus
    {
        public static Categories MenuIngresarCategoria()
        {

            MensajesPantalla.MensajeNombreCategoria();
            string nombreCategoria = Validar.IngresarValorSoloLetras(Ingreso.IngresoUsuario(), "Categoria");

            MensajesPantalla.MensajeDescripcionCategoria();
            string descripcionCategoria = Validar.IngresarValorSoloLetras(Ingreso.IngresoUsuario(), "Descripcion");

            Categories categories = new Categories
            {
                CategoryName = nombreCategoria,
                Description = descripcionCategoria
            };

            return categories;
        }

        public static Categories MenuModificarCategoria()
        {
            MensajesPantalla.MensajeIdCategoria();
            int idCategoria = Ingreso.IngresoUsuarioSoloNumeros();

            MensajesPantalla.MensajeNombreCategoria();
            string nombreCategoria = Validar.IngresarValorSoloLetras(Ingreso.IngresoUsuario(), "Categoria");

            MensajesPantalla.MensajeDescripcionCategoria();
            string descripcionCategoria = Validar.IngresarValorSoloLetras(Ingreso.IngresoUsuario(), "Descripcion");

            Categories categoriesModificar = new Categories
            {
                CategoryID = idCategoria,
                CategoryName = nombreCategoria,
                Description = descripcionCategoria
            };

            return categoriesModificar;
        }

        public static int MenuEliminarCategoria()
        {
            MensajesPantalla.MensajeIdCategoria();
            int idCategoria = Ingreso.IngresoUsuarioSoloNumeros();
            return idCategoria;
        }
    }
}