namespace TestProject.xUnit.UnitTests
{
    public class MyIDisposableTests : IDisposable
    {
        public MyIDisposableTests()
        {
            // Setup code here
            Console.WriteLine("Test setup");
        }

        [Fact]
        public void Test1()
        {
            // Test code here
            Console.WriteLine("Running Test1");
        }

        [Fact]
        public void Test2()
        {
            // Test code here
            Console.WriteLine("Running Test2");
        }

        public void Dispose()
        {
            // Cleanup code here
            Console.WriteLine("Test teardown");
        }
    }
}
