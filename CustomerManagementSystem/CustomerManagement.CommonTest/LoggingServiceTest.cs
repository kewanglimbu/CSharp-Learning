using CustomerManagement.BL;
using CustomerManagement.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {

        [TestMethod]

        public void WriteToFile()
        {
            //--- Arrange

            var changeItems= new List<ILoggable>();
            var Customer = new Customer(1)
            {
                Email = "kewang.h.limbu@gmail.com",
                FirstName = "Kewang",
                LastName = "Limbu",
                AddressList = null
            };

            changeItems.Add(Customer);

            var product = new Product(2)
            {
                ProductName = "Macbook Pro",
                Description = "Latest i9 Macbook with highend processor",
                CurrentPrice = 2000
            };

            changeItems.Add(product);


            //--- Act

            LoggingService.WriteToFile(changeItems);

            //--- Assert
            //Nothing to Assert
        }
    }
}
