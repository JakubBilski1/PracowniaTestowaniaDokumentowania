using Bogus;

namespace TestProject1
{
    public class UnitTest1
    {
        public class User
        {
            public string? Name { get; set; }
            public int Age { get; set; }
            public string? Hobby { get; set; }
            public double Weight { get; set; }
        }

        [Fact]
        public void Test1()
        {
            var userFaker = new Faker<User>("pl")
                .RuleFor(u => u.Name, f => f.Name.FirstName())
                .RuleFor(u => u.Age, f => f.Random.Int(1, 100))
                .RuleFor(u => u.Hobby, f => f.Lorem.Sentence())
                .RuleFor(u => u.Weight, f => f.Random.Double(1, 100));
        }
    }
}