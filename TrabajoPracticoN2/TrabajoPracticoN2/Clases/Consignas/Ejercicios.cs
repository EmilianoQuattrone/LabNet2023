using System;
using TrabajoPracticoN2.Clases.Consignas;

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
				throw;
			}
            finally
			{
				Mensajes.MensajeFinally();
			}
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
				throw;
            }
            finally
            {
                Mensajes.MensajeFinally();
            }
        }
    }
}