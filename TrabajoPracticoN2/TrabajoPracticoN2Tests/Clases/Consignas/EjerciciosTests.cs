using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TrabajoPracticoN2.Clases.Consignas;

namespace TrabajoPracticoN2.Clases.Tests
{
    [TestClass()]
    public class EjerciciosTests
    {
        [TestMethod()]
        public void DivisionEJN2Test()
        {
            //Arrange
            decimal dividendo = 100;
            decimal divisor = 2;
            decimal resultadoEsperado = 50;

            //Act
            decimal resultadoObtenido = Operaciones.DivisionEJN2(dividendo, divisor);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void EjercicioN2Test()
        {
            decimal dividendo = 100;
            decimal divisor = 0;

            Ejercicios.EjercicioN2(dividendo, divisor);
        }
    }
}