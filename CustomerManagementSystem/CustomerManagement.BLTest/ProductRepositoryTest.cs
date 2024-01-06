using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {

        [TestMethod]

        public void RetrieveTest()
        {
            // --- Arrange

            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                ProductName = "Macbook Pro",
                Description = "Latest i9 Macbook with highend processor",
                CurrentPrice = 2000
            };


            //--- Act
            var actual = productRepository.Retrieve(2);

            //--- Assert

            // Assert.AreEqual(expected, actual);

            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        }


        [TestMethod]
        public void SaveTestValid()
        {
            //--- Arrange 

            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                ProductName = "Nike Shoes",
                Description = "Latest Brand Nike Shoe 2024",
                CurrentPrice = 200,
                Haschanges = true
            };

            //--- Act

            var actual = productRepository.Save(updatedProduct);

            //--- Assert

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void SaveTestMissingPrice()
        {
            //--- Arrange 

            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = null,
                ProductName = "Nike Shoes",
                Description = "Latest Brand Nike Shoe 2024",
                Haschanges = true
            };

            //--- Act

            var actual = productRepository.Save(updatedProduct);

            //--- Assert

            Assert.AreEqual(false, actual);
        }


    }
}
        



