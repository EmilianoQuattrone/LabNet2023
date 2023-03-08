using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPracticoN2.Validaciones;

namespace TrabajoPracticoN2.Clases
{
    public class VolverAProbar
    {
        public static void Probar()
        {
            Mensajes.VolverAIntentarlo();
            decimal probarDeNuevo = Validar.ValidarEntradasNegativasYVacias("Para volver a intentarlo presione 1, para salir presione cualquier NUMERO.");
            Intentos.VolverAIntentarlo(probarDeNuevo);
        }
    }
}
