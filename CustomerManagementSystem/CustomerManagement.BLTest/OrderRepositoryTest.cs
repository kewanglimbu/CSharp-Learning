using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {

        [TestMethod]
        public void RetrieveOrderTest()
        {
            //--- Arrange 

            var orderRepsoitory = new OrderRepository();

            var expected = new Order(2)
            {
                OrderDate = new DateTimeOffset(DateAndTime.Now.Year, 1, 2, 12, 35, 12, new TimeSpan(5, 45, 0))
            };

            //--- Act

            var actual = orderRepsoitory.Retrieve(2);

          //--- Assert

            Assert.AreEqual(expected.OrderDate, actual.OrderDate);

        }
    }
}
