using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace msTesting
{
    [TestClass]
    public class UnitTest1
    {
        Calculator calc = new Calculator();
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int a = 10;
            int b = 20;
            int expectedResult = 30;
            //Act
            int result = calc.add(a, b);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        [DataRow(10, 30, 40)]
        [DataRow(15, 10, 25)]
        [DataRow(9, 1, 10)]
        public void TestMethod2(int x, int y, int expected)
        {
            //Act
            int result = calc.add(x, y);
            //Assert
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        [DynamicData(nameof(AdditionData))]
        public static IEnumerable<object[]> AdditionData()
        {
            yield return new object[] { 10, 20, 30 };
            yield return new object[] { 50, 25, 75 };
            yield return new object[] { 15, 10, 25 };
        }
        public void TestMethod3(int x, int y, int expected)
        {
            //Act
            int result = calc.add(x, y);
            //Assert
            Assert.AreEqual(result, expected);
        }
    }
}