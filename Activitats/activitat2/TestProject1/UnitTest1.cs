using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyApplication;

namespace activitat2Tests
{
    [TestClass]
    public class PowerTest
    {
        [TestMethod]
        public void Positive_Base_Exponent()
        {

            //Arrange

            int num = 2;
            int exp = 3;


            //Act

            int result = Power.PowerMethod(num, exp);

            //Assert

            Assert.AreEqual(result, 8);

        }

        [TestMethod]
        public void Positive_Base_Negative_Exponent()
        {

            //Arrange

            int num = 2;
            int exp = -3;


            //Act

            int result = Power.PowerMethod(num, exp);

            //Assert

            Assert.AreEqual(result, 1);

        }

        [TestMethod]
        public void Negative_Base_Positive_Exponent()
        {

            //Arrange

            int num = -2;
            int exp = 3;


            //Act

            int result = Power.PowerMethod(num, exp);

            ///Assert

            Assert.AreEqual(result, -8);

        }

        [TestMethod]
        public void Negative_Base_Negative_Exponent()
        {

            //Arrange

            int num = -2;
            int exp = -3;


            //Act

            int result = Power.PowerMethod(num, exp);

            //Assert

            Assert.AreEqual(result, 1);

        }



    }
}