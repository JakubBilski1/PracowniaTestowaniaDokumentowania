namespace Entropy
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Entropy entrophy = new Entropy();
            double result = entrophy.CalculateEntrophy("Hello World");
            double expectedResult = 2.8453509366224372;
            Assert.Equal(expectedResult, result);
        }
    }
}