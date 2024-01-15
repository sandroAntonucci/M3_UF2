using VideogameRoutines;

namespace TestProjectJanEspana
{
    [TestClass]
    public class UnitTestNoMore10CharsName
    {
        [TestMethod]
        public void EmptyString_ReturnsTrue()
        {

            //Arrange
            const string Name = "";

            //Act
            bool result = Ex31.NoMore10CharsName(Name);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CharsBetweenZeroAndTen_ReturnsTrue()
        {

            //Arrange
            const string Name = "holaquetal";

            //Act
            bool result = Ex31.NoMore10CharsName(Name);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void MoreThanTenChars_ReturnsFalse()
        {

            //Arrange
            const string Name = "holaquetal?";

            //Act
            bool result = Ex31.NoMore10CharsName(Name);

            //Assert
            Assert.IsFalse(result);
        }

    }

    [TestClass]
    public class UnitTestRandomNum
    {
        [TestMethod]
        public void RandomNum_ReturnsValidRange()
        {
            
            //Act
            int result = Ex31.RandomNum();

            //Assert
            Assert.IsTrue(result >= 1 && result <= 100);
        }
    }

    [TestClass]
    public class UnitTestNumInRange
    {
        [TestMethod]
        public void NegativeNums_ReturnsFalse()
        {
            //Arrange
            const int Num = -1;

            //Act
            bool result = Ex31.NumInRange(Num);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void NumBetweenOneAnd500_ReturnsTrue()
        {
            //Arrange
            const int Num = 1;

            //Act
            bool result = Ex31.NumInRange(Num);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void NumGreaterThan500_ReturnsFalse()
        {
            //Arrange
            const int Num = 501;

            //Act
            bool result = Ex31.NumInRange(Num);

            //Assert
            Assert.IsFalse(result);
        }
    }

}