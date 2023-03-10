using Lab.EF.Entidades;
using Lab.EF.Logica;
using Lab.EF.Logica.OtrasFuncionalidades;
using Lab.EF.UI.InterfazUsuario;
using System.Data.Entity.Validation;

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