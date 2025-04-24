using TestProject.xUnit.TestFixtures;

namespace TestProject.xUnit.UnitTests
{
    [Collection("Database collection")]
    public class DatabaseTestClass1
    {
        private readonly DatabaseFixture _fixture;

        public DatabaseTestClass1(DatabaseFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Test1()
        {
            // Use _fixture to perform test
            Console.WriteLine("Running Test1");
            Assert.True(true);
        }
    }


}
