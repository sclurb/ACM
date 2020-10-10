using System;
using System.Collections.Generic;
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

        [TestMethod]
        public void SaveTestValid()
        {
            //-- Arrange
            var orderRepository = new OrderRepository();
            var updateOrder = new Order(2)
            {
                OrderDate = new DateTime(2020, 10, 09),
                OrderItems = new List<OrderItem> 
                { new OrderItem 
                    { 
                        ProductId = 1,
                        PurchasePrice = 12m,
                        Quantity = 2
                    } 
                },
                HasChanges = true
            };
            //--Act
            var actual = orderRepository.Save(updateOrder);
            //Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void SaveTestMissingOrderDatee()
        {
            //-- Arrange
            var orderRepository = new OrderRepository();
            var updateOrder = new Order(2)
            {
                OrderDate = null,
                OrderItems = new List<OrderItem> 
                { new OrderItem
                    {
                        ProductId = 1,
                        PurchasePrice = 12m,
                        Quantity = 2
                    }
                },
                HasChanges = true
            };
            //--Act
            var actual = orderRepository.Save(updateOrder);
            //Assert
            Assert.AreEqual(false, actual);
        }
    }
}
