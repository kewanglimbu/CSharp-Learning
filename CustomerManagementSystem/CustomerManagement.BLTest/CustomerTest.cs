namespace CustomerManagement.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTest()
        {
            //Arrange

            Customer customer = new Customer
            {
                FirstName = "Kewang",
                LastName = "Limbu"
            };

            string expected = "Kewang,Limbu";
            //Act
            string actual = customer.FullName();

            //Assert
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void StaticTest()
        {
            var c1 = new Customer();
            c1.FirstName = "Kewang";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Sasuke";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Naruto";
            Customer.InstanceCount += 1;

            Assert.AreEqual(3, Customer.InstanceCount);

        }
    }
}