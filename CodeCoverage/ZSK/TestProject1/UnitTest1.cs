using Domain.NewDirectory;
using Domain.VeryNewDirectory;

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1.0, true)]
        [InlineData(0.0, true)]
        [InlineData(0.1, true)]
        [InlineData(-0.1, false)]
        [InlineData(-1.0, false)]
        public void ShoulDepositMoneyIntoEmptyBankAccount(double moneyToDeposit, bool shouldDeposit)
        {
            BankAccount bankAccount = new BankAccount();
            var isDeposited = bankAccount.Deposit(moneyToDeposit);
            Assert.Equal(shouldDeposit, isDeposited);
        }

        [Theory]
        [InlineData(1.1, 1.1)]
        public void AddingMoney(double addMoney, double shouldBe)
        {
            BankAccount bankAccount = new BankAccount();

            bankAccount.Deposit(addMoney);
            var currentBalance = bankAccount.GetBalance();
            Assert.Equal(shouldBe, currentBalance);
        }

        [Theory]
        [InlineData(4, true)]
        [InlineData(-2, false)]
        [InlineData(10, false)]
        public void ShouldWithdrawMoney(double moneyToWithdraw, bool shouldWithdraw)
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.Deposit(5);
            var isWithdrawn = bankAccount.Withdraw(moneyToWithdraw);
            Assert.Equal(shouldWithdraw, isWithdrawn);
        }
        [Theory]
        [InlineData(3, 3)]
        public void GettingPassengers(int passengers, int shouldBe)
        {
            Car car = new Car(5);
            car.AddPassengers(passengers);
            var currentPassengers = car.GetNumberOfPassengers();
            Assert.Equal(shouldBe, currentPassengers);
        }
        [Theory]
        [InlineData(3, true)]
        [InlineData(-2, false)]
        [InlineData(10, false)]
        public void AddingPassengers(int passengers, bool shouldBe)
        {
            Car car = new Car(5);
            var isAdded = car.AddPassengers(passengers);
            Assert.Equal(shouldBe, isAdded);
        }
        [Theory]
        [InlineData(20, 15, 5)]
        public void GettingGreatestCommonDivisor(int a, int b, int shouldBe)
        {
            var gcd = GreatestCommonDivisor.GCDiterative(a, b);
            Assert.Equal(shouldBe, gcd);
        }
        [Theory]
        [InlineData(20, 15, 5)]
        public void GettingGreatestCommonDivisorRecursion(int a, int b, int shouldBe)
        {
            var gcd = GreatestCommonDivisor.GCDrecursive(a, b);
            Assert.Equal(shouldBe, gcd);
        }
        [Theory]
        [InlineData(1, 2, 2, 1)]
        public void GettingSwappedNumbers(int x, int y, int shouldBeX, int shouldBeY)
        {
            NumberSwap.NormalVariableSwap(x, y, out int resultX, out int resultY);
            Assert.Equal(shouldBeX, resultX);
            Assert.Equal(shouldBeY, resultY);
        }
        [Theory]
        [InlineData(1, 2, 2, 1)]
        public void GettingSwappedNumbersMagic(int x, int y, int shouldBeX, int shouldBeY)
        {
            NumberSwap.MagicVariableSwap(x, y, out int resultX, out int resultY);
            Assert.Equal(shouldBeX, resultX);
            Assert.Equal(shouldBeY, resultY);
        }
        [Theory]
        [InlineData("abababcabcabc")]
        [InlineData("abababab")]
        public void GettingCompressedString(string uncompressed)
        {
            var compressed = LZW.Compress(uncompressed);
            var decompressed = LZW.Decompress(compressed);
            Assert.Equal(uncompressed, decompressed);
        }
    }
}