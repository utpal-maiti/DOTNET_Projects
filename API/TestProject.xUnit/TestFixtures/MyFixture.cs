using Xunit.Abstractions;

namespace TestProject.xUnit.TestFixtures
{
    public class MyFixture : IDisposable
    {
        private readonly ITestOutputHelper _output;

        public MyFixture(ITestOutputHelper output)
        {
            _output = output;
            _output.WriteLine("Class setup");
        }

        public void Dispose()
        {
            _output.WriteLine("Class teardown");
        }
    }
}
