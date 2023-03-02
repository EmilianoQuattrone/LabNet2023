using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPracticoN1.Clases;

namespace TrabajoPracticoN1.Menus
{
    public class MenuUsuario
    {
        public static void MenuOpciones(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    Ingresar.IngresarOmnibus();
                    break;

                case 2:
                    Ingresar.IngresarTaxis();
                    break;
            }
        }
    }
}