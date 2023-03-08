using System;
using TrabajoPracticoN2.Validaciones;

namespace TrabajoPracticoN2.Clases.Consignas
{
    public class Logic
    {
        public static void LanzarExcepcion()
        {    
            throw new FormatException();
        }

        public static void LanzarExcepcionPersonalizada()
        {
             string mensajePersonal = "Mensaje excepcion personal";
             throw new ExcepcionesPersonalizadas(mensajePersonal);
        }

        public static void Capturar()
        {
            try
            {
                LanzarExcepcion();
            }
            catch (DivideByZeroException ex)
            {
                Mensajes.MensajeEjercicioN3(ex.Message);
                Mensajes.MensajeTipo(ex);
            }

            catch (Exception ex) 
            {
                Mensajes.MensajeEjercicioN3(ex.Message);
                Mensajes.MensajeTipo(ex);
            }
            finally
            {
                Mensajes.MensajeFinally();
                Mensajes.VolverAIntentarlo();
                decimal probarDeNuevo = Validar.ValidarEntradasNegativasYVacias("Para volver a intentarlo presione 1");
                Intentos.VolverAIntentarlo(probarDeNuevo);
            }
        }

        public static void CapturarExcepcionPersonalizada()
        {
            try
            {
                LanzarExcepcionPersonalizada();
            }
            catch (Exception ex)
            {
                Mensajes.MensajeEjercicioN4(ex.Message);
                Mensajes.MensajeTipoEJ4(ex);
            }
            finally
            {
                Mensajes.MensajeFinally();
                Mensajes.VolverAIntentarlo();
                decimal probarDeNuevo = Validar.ValidarEntradasNegativasYVacias("Para volver a intentarlo presione 1");
                Intentos.VolverAIntentarlo(probarDeNuevo);
            }
        }
    }
}