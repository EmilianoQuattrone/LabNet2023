using Lab.EF.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity.Validation;

namespace Lab.EF.UI.Logica.Tests
{
    [TestClass()]
    public class CategoriasTests
    {
        [TestMethod()]
        [ExpectedException(typeof(DbEntityValidationException))]
        public void IngresarCategoriaTest()
        {
            Categories categories = new Categories();
            Categorias.IngresarCategoria(categories);
        }
    }
}