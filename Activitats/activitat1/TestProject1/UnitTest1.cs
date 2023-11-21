using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyApplication;

namespace activitat1Tests
{
    [TestClass]
    public class ValidateTest
    {
        [TestMethod]
        public void IsPositive_InputGreaterThanZero_ReturnsTrue()
        {

            //Arrange

            int num = 1;

            //Act

            bool result = NaturalNumbers.Validate(num);

            //Assert

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void IsNegative_InputGreaterThanZero_ReturnsFalse()
        {

            //Arrange

            int num = -5;

            //Act

            bool result = NaturalNumbers.Validate(num);

            //Assert

            Assert.IsFalse(result);

        }


    }
}