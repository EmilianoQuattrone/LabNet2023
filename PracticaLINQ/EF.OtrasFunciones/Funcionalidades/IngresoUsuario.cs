using EF.OtrasFunciones.Validaciones;

namespace EF.OtrasFunciones.Funcionalidades
{
    public class IngresoUsuario
    {
        public static int IngresoUsuarioSoloNumeros()
        {
            int ingreso = Validar.ValidarEntradasNegativasYVacias("Solo ingrese numero: ");
            return ingreso;
        }
    }
}