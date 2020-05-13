using System;
using KarenHarte_S00182304;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestPriceIncrease
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Phone phonePrice = new Phone();
            int expectedResult = 14;

            //Act
            phonePrice.IncreasePrice(20);

            //Assert
            Assert.AreEqual(expectedResult, phonePrice.Price);

        }
    }
}
