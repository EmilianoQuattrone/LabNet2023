using Lab.EF.Entidades;
using Lab.EF.Logica;
using Lab.EF.Logica.OtrasFuncionalidades;
using Lab.EF.UI.InterfazUsuario;
using System;
using System.Collections.Generic;

namespace Lab.EF.UI.Logica
{
    public class Empleados
    {
        public static void ObtenerEmpleados()
        {
            try
            {
                EmpleadosLogica empleadosLogica = new EmpleadosLogica();
                List<Employees> empleadosLogicaLista = empleadosLogica.ObtenerTodos();

                foreach (var item in empleadosLogicaLista)
                {
                    MensajesPantalla.MensajeListaEmpleado(item);
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
    }
}