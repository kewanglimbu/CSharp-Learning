using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {

        [TestMethod]

        public void RetrieveValid()
        {
            //--- Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                //error. Reason:CustomerId property setter is private
                //CustomerId=1, 
                Email = "kewang.h.limbu@gmail.com",
                FirstName = "Kewang",
                LastName = "Limbu"
            };

            //--- Act
            var actual = customerRepository.Retrieve(1);

            //--- Assert

            // Assert.AreEqual(expected, actual);

            Assert.AreEqual(expected.Email, actual.Email);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }


        [TestMethod]

        public void RetrieveExistingWithAddress()
        {
            //--- Arrange

            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                Email = "kewang.h.limbu@gmail.com",
                FirstName = "Kewang",
                LastName = "Limbu",
                AddressList = new List<Address>
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine = "I Street",
                        City = "Itahari",
                        Province = "province 3",
                        Country = "Nepal",
                        PostalCode = "234567"
                    },

                    new Address()
                    {
                        AddressType = 2,
                        StreetLine = "B Street",
                        City = "Biratchowk",
                        Province = "province 3",
                        Country = "Nepal",
                        PostalCode = "345678"
                    },

                    new Address()
                    {
                        AddressType = 3,
                        StreetLine = "G Street",
                        City = "Y city",
                        Province = "province 3",
                        Country = "Nepal",
                        PostalCode = "345679"
                    }
                }

            };


            //--- Act

            var actual = customerRepository.Retrieve(1);


            //--- Assert

            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.Email, actual.Email);

            for(int i=0;i<1;i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, expected.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine, expected.AddressList[i].StreetLine);
                Assert.AreEqual(expected.AddressList[i].City, expected.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].Province, expected.AddressList[i].Province);
                Assert.AreEqual(expected.AddressList[i].Country, expected.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, expected.AddressList[i].PostalCode);

            }





        }
    }
}
