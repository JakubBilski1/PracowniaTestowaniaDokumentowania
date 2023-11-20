using Maths;

namespace msTests
{
    [TestClass]
    public class UnitTest1
    {
        Calculator calc = new Calculator();
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int a = 2;
            int b = 3;
            int expected = 6;
            //Act
            int result = calc.multiply(a, b);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        [DataRow(2, 3, 6)]
        [DataRow(3, 3, 9)]
        [DataRow(2, 5, 10)]
        public void TestMethod2(int a, int b, int expected)
        {
            //Arrange
            int result = calc.multiply(a, b);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DynamicData(nameof(MultiplyData), DynamicDataSourceType.Method)]
        public void TestMethod3(int a, int b, int expected)
        {
            //Arrange
            int result = calc.multiply(a, b);
            //Assert
            Assert.AreEqual(expected, result);
        }
        public static IEnumerable<object[]> MultiplyData()
        {
            yield return new object[] { 2, 3, 6 };
            yield return new object[] { 3, 3, 9 };
            yield return new object[] { 2, 5, 10 };
        }
    }
}