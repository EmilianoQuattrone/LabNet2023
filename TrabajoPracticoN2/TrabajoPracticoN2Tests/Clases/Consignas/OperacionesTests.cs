using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TrabajoPracticoN2.Clases.Consignas.Tests
{
    [TestClass()]
    public class OperacionesTests
    {
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisionEJN1Test()
        {
            decimal numero1 = 10;

            Ejercicios.EjercicioN1(numero1);
        }
    }
}