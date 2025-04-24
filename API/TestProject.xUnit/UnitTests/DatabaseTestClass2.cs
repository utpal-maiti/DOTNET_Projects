using TestProject.xUnit.TestFixtures;

namespace TestProject.xUnit.UnitTests
{
    [Collection("Database collection")]
    public class DatabaseTestClass2
    {
        private readonly DatabaseFixture _fixture;

        public DatabaseTestClass2(DatabaseFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Test2()
        {
            // Use _fixture to perform test
            Console.WriteLine("Running Test2");
            Assert.True(true);
        }
    }
}
