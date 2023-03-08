using System;
using TrabajoPracticoN2.Clases.Consignas;
using TrabajoPracticoN2.Validaciones;

namespace TrabajoPracticoN2.Clases
{
    public class Ejercicios
    {
        public static void EjercicioN1(decimal numero)
        {
            try
            {
                Operaciones.DivisionEJN1(numero);
            }
            catch (DivideByZeroException ex)
            {
                Mensajes.MensajeDivisionEn0(ex.Message);
            }
            finally
            {
                Mensajes.MensajeFinally();
            }

            Mensajes.VolverAIntentarlo();
            decimal probarDeNuevo = Validar.ValidarEntradasNegativasYVacias("Para volver a intentarlo presione 1");
            Intentos.VolverAIntentarlo(probarDeNuevo);
        }

		public static void EjercicioN2(decimal dividendo, decimal divisor)
		{
			try
			{
				Operaciones.DivisionEJN2(dividendo, divisor);
			}
            catch (DivideByZeroException ex)
            {
                Mensajes.MensajeDivisionEn0(ex.Message);
            }
            finally
            {
                Mensajes.MensajeFinally();          
            }

            Mensajes.VolverAIntentarlo();
            decimal probarDeNuevo = Validar.ValidarEntradasNegativasYVacias("Para volver a intentarlo presione 1");
            Intentos.VolverAIntentarlo(probarDeNuevo);
        }
    }
}