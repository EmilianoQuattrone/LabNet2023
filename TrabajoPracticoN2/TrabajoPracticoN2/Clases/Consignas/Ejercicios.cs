using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }
    }
}