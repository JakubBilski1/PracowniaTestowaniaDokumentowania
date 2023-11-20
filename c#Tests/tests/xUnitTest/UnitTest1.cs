using Maths;

namespace xUnitTest
{
    public class UnitTest1
    {
        Calculator calc = new();
        [Fact]
        public void Test1()
        {
            //Arrange
            int a = 2;
            int b = 3;
            int expected = 6;
            //Act
            int result = calc.multiply(a, b);
            //Assert
            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(3, 3, 9)]
        [InlineData(2, 5, 10)]
        public void Test2(int a, int b, int expected)
        {
            //Arrange
            int result = calc.multiply(a, b);
            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(MultiplyData))]
        public void Test3(int a, int b, int expected)
        {
            //Arrange
            int result = calc.multiply(a, b);
            //Assert
            Assert.Equal(expected, result);
        }
        public static IEnumerable<object[]> MultiplyData()
        {
            yield return new object[] { 2, 3, 6 };
            yield return new object[] { 3, 3, 9 };
            yield return new object[] { 2, 5, 10 };
        }

        [Theory]
        [MemberData(nameof(MultiplyInputData))]
        public void Test4(int a, int b, int expected)
        {
            var method = typeof(Calculator).GetMethod("multiply");
            if (method != null)
            {
                var result = method.Invoke(calc, new object[] { a, b });
                Assert.Equal(expected, result);
            }
            else
            {
                Assert.Fail("Method not found");
            }
            //int result = calc.multiply(a, b);
            //Assert.Equal(expected, result);
        }
        public static IEnumerable<object[]> MultiplyInputData()
        {
            yield return new object[] { 2, 3, 6 };
            yield return new object[] { 3, 3, 9 };
            yield return new object[] { 2, 5, 10 };
        }
    }
}