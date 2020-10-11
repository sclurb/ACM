using System;
using System.Collections.Generic;
using System.Runtime.Remoting;
using ACM.BL;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFiletest()
        {
            //--Arrange
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden rake with steel head",
                CurrentPrice = 6m
            };
            changedItems.Add(product);
            //--Act
            LoggingService.WriteToFile(changedItems);

            //--Assert
        }
    }
}
