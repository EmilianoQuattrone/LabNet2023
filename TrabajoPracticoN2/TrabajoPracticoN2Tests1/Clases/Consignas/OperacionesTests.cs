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
    }
}