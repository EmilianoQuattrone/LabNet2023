using PracticaLINQ.OtrasFunciones;

namespace PracticaLINQ.OtrasFunciones
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