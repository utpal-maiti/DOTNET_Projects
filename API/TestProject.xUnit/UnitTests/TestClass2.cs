using TestProject.xUnit.TestFixtures;

namespace TestProject.xUnit.UnitTests
{
    [Collection("My Collection")]
    public class TestClass2
    {
        private readonly MyFixture _fixture;

        public TestClass2(MyFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Test2()
        {
            Console.WriteLine("Running TestClass2.Test2");
        }
    }


}
