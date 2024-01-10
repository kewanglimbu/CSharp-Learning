using CustomerManagement.Common;

namespace CustomerManagement.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
          /* Test cases:
             
         --- Test case 1:

            var source = ""KewangLimbu";
            var expected  ="Kewang Limbu";

         --- Test case 2:

            var source = "Kewang Limbu";
            var expected = "Kewang Limbu"; 
          
         --- Test more.... 
         */


            //--- Arrange
            var source = "Kewang Limbu";
            var expected = "Kewang Limbu";
           // var handler = new StringHandler(); // create instance of StringHandler class


            //--- Act

            var actual = source.InsertSpace();

            //--- Assert

            Assert.AreEqual(expected, actual);


        }
    }
}