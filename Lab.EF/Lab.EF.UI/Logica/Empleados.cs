using Lab.EF.Logica;
using Lab.EF.Logica.OtrasFuncionalidades;
using Lab.EF.UI.InterfazUsuario;
using System;

namespace Lab.EF.UI.Logica
{
    public class Empleados
    {
        public static void ObtenerEmpleados()
        {
            try
            {
                EmpleadosLogica empleadosLogica = new EmpleadosLogica();
                empleadosLogica.ListadoEmpleados();
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
    }
}