using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrabajoPracticoN2.Clases.Consignas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoN2.Clases.Consignas.Tests
{
    [TestClass()]
    public class OperacionesTests
    {
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisionEJN1Test()
        {
            decimal dividendo = 10;

            Operaciones.DivisionEJN1(dividendo);
        }

        [TestMethod()]
        public void DivisionEJN2Test()
        {
            //Arrenge
            decimal dividendo = 10;
            decimal divisor = 2;
            decimal resultadoEsperado = 5;

            //Act
            decimal resultadoObtenido =  Operaciones.DivisionEJN2(dividendo, divisor);

            //Assert
            Assert.AreEqual(resultadoObtenido, resultadoEsperado);
        }

        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisionEJN2NegativoTest()
        {
            decimal dividendo = 10;
            decimal divisor = 0;

            Operaciones.DivisionEJN2(dividendo, divisor);
        }
    }
}