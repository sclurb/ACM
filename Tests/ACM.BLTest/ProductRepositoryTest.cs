using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //--Arrange
            ProductRepository repo = new ProductRepository();
            var expected= new Product(1)
            {
                ProductName = "Widget",
                CurrentPrice = 12.99M,
                ProductDescription = "Thing that is something"
            };
            //--Act
            var actual = repo.Retrieve(1);

            //--Assert
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
        }
    }
}
