using System;
using System.Collections.Generic;
using Acme.Common;
using LN_ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            var changedItems = new List<ILoggable>();
            var customer = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbit.com",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = null
            };

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden Rake with Steel Head",
                CurrentPrice = 6M
            };
            changedItems.Add(product);


            LoggingService.WriteToFile(changedItems);



        }
    }
}
