using Lab.EF.Entidades;
using Lab.EF.Logica;
using Lab.EF.Logica.OtrasFuncionalidades;
using Lab.EF.UI.InterfazUsuario;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;

namespace Lab.EF.UI.Logica
{
    public class Categorias
    {
        public static void ObtenerCategorias()
        {
            try
            {
                CategoriasLogica categoriasLogica = new CategoriasLogica();
                List<Categories> categoriasLogicaLista = categoriasLogica.ObtenerTodos();

                foreach (var item in categoriasLogicaLista)
                {
                    MensajesPantalla.ListadoCategorias(item);
                }
            }
            catch (Exception ex)
            {
                MensajesPantalla.MensajeExcepcionesGenerico(ex);
            }
            finally
            {
                Intentos.VolverAIntentar();
            }
        }      

        public static void IngresarCategoria(Categories categories)
        {
            try
            {
                CategoriasLogica categoriasLogica = new CategoriasLogica();
                categoriasLogica.Add(categories);
                MensajesPantalla.MensajeDeConfirmacion();
            }
            catch (DbEntityValidationException ex)
            {
                MensajesPantalla.MensajeExcepciones(ex);
            }
            finally
            {
                Intentos.VolverAIntentar();
            }
        }

        public static void ModificarCategoria(Categories categories)
        {
            try
            {
                CategoriasLogica categoriasLogica = new CategoriasLogica();
                categoriasLogica.Modificar(categories);
                MensajesPantalla.MensajeDeConfirmacion2();
            }
            catch (DbEntityValidationException ex)
            {
                MensajesPantalla.MensajeExcepciones(ex);
            }
            catch (InvalidOperationException ex)
            {
                MensajesPantalla.MensajeExcepcion3(ex);
            }
            finally
            {
                Intentos.VolverAIntentar();
            }
        }

        public static void EliminarCategoria(int id)
        {
            try
            {
                CategoriasLogica categoriasLogica = new CategoriasLogica();
                categoriasLogica.Eliminar(id);
                MensajesPantalla.MensajeDeConfirmacion3();
            }
            catch (DbUpdateException ex)
            {
                MensajesPantalla.MensajeExcepcion4(ex);
            }
            catch (ArgumentNullException ex)
            {
                MensajesPantalla.MensajeExcepciones2(ex);
            }
            finally
            {
                Intentos.VolverAIntentar();
            }
        }
    }
}