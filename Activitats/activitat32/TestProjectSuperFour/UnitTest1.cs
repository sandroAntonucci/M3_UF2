using MyApplication;

namespace TestProjectSuperFour
{
    [TestClass]
    public class UnitTestCheckNumBetweenRange
    {
        [TestMethod]
        public void NegativeNum_PositiveRange()
        {

            //Arrange

            const int num = -1, min = 1, max = 100;

            //Act
            bool result = SuperFour.CheckNumBetweenRange(num, min, max);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void PositiveNum_InRange()
        {

            //Arrange

            const int num = 2, min = 1, max = 100;

            //Act
            bool result = SuperFour.CheckNumBetweenRange(num, min, max);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void PositiveNum_NotInRange()
        {

            //Arrange

            const int num = 101, min = 1, max = 100;

            //Act
            bool result = SuperFour.CheckNumBetweenRange(num, min, max);

            //Assert
            Assert.IsFalse(result);
        }
    }

    [TestClass]
    public class UnitTestCheckNoSpecialChars
    {
        [TestMethod]
        public void EmptyString_ReturnsTrue()
        {

            //Arrange

            const string name = "";

            //Act
            bool result = SuperFour.CheckNoSpecialChars(name);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void StringWithSpecialChars_ReturnsFalse()
        {

            //Arrange

            const string name = "$andro";

            //Act
            bool result = SuperFour.CheckNoSpecialChars(name);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void StringWithoutSpecialChars_ReturnsTrue()
        {

            //Arrange

            const string name = "Sandro";

            //Act
            bool result = SuperFour.CheckNoSpecialChars(name);

            //Assert
            Assert.IsTrue(result);
        }
    }

    [TestClass]
    public class UnitTestCheckTwoVocalsInName
    {
        [TestMethod]
        public void EmptyString_ReturnsFalse()
        {

            //Arrange

            const string name = "";

            //Act
            bool result = SuperFour.CheckTwoVocalsInName(name);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void StringWithNoVocals_ReturnsFalse()
        {

            //Arrange

            const string name = "sdfd";

            //Act
            bool result = SuperFour.CheckTwoVocalsInName(name);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void StringWithTwoVocals_ReturnsTrue()
        {

            //Arrange

            const string name = "Sandro";

            //Act
            bool result = SuperFour.CheckTwoVocalsInName(name);

            //Assert
            Assert.IsTrue(result);
        }
    }

    [TestClass]
    public class UnitTestAssignWholeMagicDust
    {
        [TestMethod]
        public void AssignsWholeMagicDustCorrectly()
        {

            //Arrange

            int evil = 4001, magicDustOne = 0, magicDustTwo = 0, magicDustThree = 0, magicDustFour = 0;

            //Act
            SuperFour.AssignWholeMagicDust(ref evil, ref magicDustOne, ref magicDustTwo, ref magicDustThree, ref magicDustFour); 

            //Assert
            Assert.AreEqual(magicDustOne, evil / 4);
            Assert.AreEqual(magicDustTwo, evil / 4);
            Assert.AreEqual(magicDustThree, evil / 4);
            Assert.AreEqual(magicDustFour, evil / 4);
            Assert.AreEqual(evil, evil % 4);
        }

    }

    [TestClass]
    public class UnitTestAssignPartialMagicDust
    {
        [TestMethod]
        public void AssignsPartialMagicDustCorrectly()
        {

            //Arrange

            int evil = 4001, magicDustOne = 0, magicDustTwo = 0, magicDustThree = 0, magicDustFour = 0;

            //Act
            SuperFour.AssignPartialMagicDust(ref evil, ref magicDustOne, ref magicDustTwo, ref magicDustThree, ref magicDustFour);

            //Assert
            Assert.AreEqual(magicDustOne, evil * 5 / 100);
            Assert.AreEqual(magicDustTwo, evil * 5 / 100);
            Assert.AreEqual(magicDustThree, evil * 5 / 100);
            Assert.AreEqual(magicDustFour, evil * 5 / 100);
            Assert.AreEqual(evil, evil * 80 / 100);
        }

    }

}