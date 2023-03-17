using PracticaLINQ.Validaciones;

namespace PracticaLINQ.Funcionalidades
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