using Lab.EF.Entidades;
using Lab.EF.UI.InterfazUsuario;
using Lab.EF.UI.Validaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.UI.Menus
{
    public class OtrosMenus
    {
        public static Categories MenuCategoria()
        {
            int idCategoria = Validar.ValidarEntradasNegativasYVacias("Esta campo acepta valores numericos");
            MensajesPantalla.MensajeNombreCategoria();
            string nombreCategoria = Console.ReadLine();
            MensajesPantalla.MensajeDescripcionCategoria();
            string descripcionCategoria = Console.ReadLine();

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
