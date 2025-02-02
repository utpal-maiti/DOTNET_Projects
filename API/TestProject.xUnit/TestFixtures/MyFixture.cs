namespace TestProject.xUnit.TestFixtures
{
    public class MyFixture : IDisposable
    {
        public MyFixture()
        {
            // Collection setup code here
            Console.WriteLine("Collection setup");
        }

        public void Dispose()
        {
            // Collection cleanup code here
            Console.WriteLine("Collection teardown");
        }
    }
}
