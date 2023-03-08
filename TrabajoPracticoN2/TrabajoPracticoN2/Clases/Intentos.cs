using TrabajoPracticoN2.Validaciones;

namespace TrabajoPracticoN2.Clases
{
    public class Intentos
    {
        public static void VolverAIntentarlo(decimal op)
        {
            if (op == 1)
            {
                Mensajes.MensajesConsola();
                decimal num = Validar.ValidarEntradasNegativasYVacias("Ingrese solo numeros");
                Menu.MenuUsuario(num);
            }
            else
            {
                Mensajes.MensajeFinDePrograma();
            }
        }
    }
}