using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            OrderRepository orderRepository = new OrderRepository();
            var expected = new Order(1)
            {
                OrderDate = new DateTime(2020, 10, 9)
            };

            //Act
            var actual = orderRepository.Retrieve(1);
            //Assert
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
    }
}
