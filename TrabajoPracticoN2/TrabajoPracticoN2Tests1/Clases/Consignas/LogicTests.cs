﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrabajoPracticoN2.Clases.Consignas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoN2.Clases.Consignas.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void LanzarExcepcionTest()
        {
            Logic.LanzarExcepcion();
        }

        [TestMethod()]
        public void LanzarExcepcionPersonalizadaTest()
        {
            Logic.LanzarExcepcionPersonalizada();
        }
    }
}