using Xunit;
using msTesting;
using System.Collections.Generic;

namespace xUnitTesting
{
    public class UnitTest1
    {
        Calculator calc = new Calculator();

        [Fact]
        public void Test1()
        {
            //Arrange
            int a = 4;
            int b = 5;
            int expected = 9;
            //Act
            int result = calc.add(a, b);
            //Assert
            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData(4, 5, 9)]
        [InlineData(6, 10, 16)]
        [InlineData(2, 5, 7)]
        public void Test2(int a, int b, int expected)
        {
            //Act
            int result = calc.add(a, b);
            //Assert
            Assert.Equal(expected, result);
        }
        [Theory]
        [MemberData(nameof(AdditionData))]
        public void Test3(int a, int b, int expected)
        {
            //Act
            int result = calc.add(a, b);
            //Assert
            Assert.Equal(expected, result);
        }
        public static IEnumerable<object[]> AdditionData()
        {
            yield return new object[] { 1, 2, 3 };
            yield return new object[] { 2, 3, 5 };
            yield return new object[] { 3, 4, 7 };
        }
    }
}