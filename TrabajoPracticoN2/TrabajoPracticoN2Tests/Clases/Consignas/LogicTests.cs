using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TrabajoPracticoN2.Clases.Consignas.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        [ExpectedException(typeof(FormatException))]
        public void CapturarTest()
        {
            Logic.Capturar();
        }

        [TestMethod()]
        [ExpectedException(typeof(ExcepcionesPersonalizadas))]
        public void CapturarExcepcionPersonalizadaTest()
        {
            Logic.CapturarExcepcionPersonalizada();
        }
    }
}