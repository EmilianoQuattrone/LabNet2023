using Lab.EF.Entidades;
using Lab.EF.UI.InterfazUsuario;
using Lab.EF.UI.Validaciones;
using System;

namespace Lab.EF.UI.Menus
{
    public class OtrosMenus
    {
        public static Categories MenuCategoria()
        {
            int idCategoria = Validar.ValidarEntradasNegativasYVacias("Esta campo acepta valores numericos");
            MensajesPantalla.MensajeNombreCategoria();
            string nombreCategoria = Validar.IngresarValorSoloLetras(Console.ReadLine(),"Categoria");
            
            MensajesPantalla.MensajeDescripcionCategoria();
            string descripcionCategoria = Validar.IngresarValorSoloLetras(Console.ReadLine(),"Descripcion");

            Categories categories = new Categories
            {
                CategoryID = idCategoria,
                CategoryName = nombreCategoria,
                Description = descripcionCategoria
            };

            return categories;
        }
    }
}