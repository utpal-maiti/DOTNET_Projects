using TestProject.xUnit.TestFixtures;

namespace TestProject.xUnit.UnitTests
{
    public class MyDatabaseTests : IClassFixture<DatabaseFixture>
    {
        private readonly DatabaseFixture _fixture;

        public MyDatabaseTests(DatabaseFixture fixture)
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

        [Fact]
        public void Test2()
        {
            // Use _fixture to perform test
            Console.WriteLine("Running Test2");
            Assert.True(true);
        }
    }
}
