using Testing;

namespace AC1Tests
{
    [TestClass]
    public class ValidateTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange

            int num = 5;

            //Act

            bool result = Validate.IsPositive(num);

            //Assert
         
            Assert.IsTrue(result);

        }
    }
}