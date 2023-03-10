using Lab.EF.Entidades;
using Lab.EF.Logica;
using Lab.EF.Logica.OtrasFuncionalidades;
using Lab.EF.UI.InterfazUsuario;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.UI.Logica
{
    public class Categorias
    {
        public static void ObtenerCategorias()
        {
            CategoriasLogica categoriasLogica = new CategoriasLogica();
            categoriasLogica.ListarCategorias();
        }      

        public static void IngresarCategoria(Categories categories)
        {
            try
            {
                CategoriasLogica categoriasLogica = new CategoriasLogica();
                categoriasLogica.Add(categories);
            }
            catch (DbEntityValidationException ex)
            {
                MensajesPantalla.MensajeExcepciones(ex);
            }
            finally
            {
                MensajesPantalla.VolverAIntentarlo();
                Intentos.VolverAIntentar();
            }
        }
    }
}