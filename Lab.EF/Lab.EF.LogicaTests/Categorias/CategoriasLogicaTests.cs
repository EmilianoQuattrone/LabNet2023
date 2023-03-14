using Lab.EF.Logica;
using Lab.EF.Data;
using Lab.EF.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Data.Entity;
using System.Threading;

namespace Lab.EF.Logica.Tests
{
    [TestClass()]
    public class CategoriasLogicaTests
    {
        [TestMethod()]
        public void AddTestConMoq()
        {

            var mockDbSet = new Mock<DbSet<Categories>>();
            var mockNorthwindContext = new Mock<NorthwindContext>();

            mockNorthwindContext.Setup(m => m.Categories).Returns(mockDbSet.Object);

            CategoriasLogica categoriasLogica = new CategoriasLogica(mockNorthwindContext.Object);
            Categories categories = new Categories()
            {
                CategoryName = "CategoriaTest",
                Description = "CategoriaTest",
            };
            categoriasLogica.Add(categories);

            mockDbSet.Verify(m => m.Add(categories), Times.Once());
            mockNorthwindContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        [TestMethod()]
        public void ModificarTest()
        {
            var categoriaModificar = new Categories() { CategoryID = 44, CategoryName = "BEBIDAS",
                Description = "PEPSI"};

            var mock = new Mock<ICRUD<Categories>>();

            mock.Setup(m => m.Modificar(It.IsAny<Categories>()))
                .Callback((Categories categories) =>
                categories.CategoryName = "Bebidas");

            mock.Object.Modificar(categoriaModificar);

            Assert.AreEqual("Bebidas", categoriaModificar.CategoryName);
        }
    }
}