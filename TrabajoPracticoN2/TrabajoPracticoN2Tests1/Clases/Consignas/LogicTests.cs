using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TrabajoPracticoN2.Clases.Consignas.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        [ExpectedException(typeof(FormatException))]
        public void LanzarExcepcionTest()
        {
            Logic.LanzarExcepcion();
        }

        [TestMethod()]
        [ExpectedException(typeof(ExcepcionesPersonalizadas))]
        public void LanzarExcepcionPersonalizadaTest()
        {
            Logic.LanzarExcepcionPersonalizada();
        }
    }
}