﻿using EF.Logica.Productos;
using PracticaLINQ.Funcionalidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLINQ.Logica.Producto
{
    public class ProductPrimeroUI
    {
        public static void ObtenerProductPrimero()
        {
            ProductPrimero.ObtenerConsulta();
            Intentos.VolverAIntentarlo();
        }
    }
}