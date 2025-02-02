namespace TestProject.xUnit.TestFixtures
{
    public class AnotherFixture : IDisposable
    {
        public AnotherFixture()
        {
            // Setup code here (e.g., open a database connection)
            Console.WriteLine("Database setup");
        }

        public void Dispose()
        {
            // Cleanup code here (e.g., close the database connection)
            Console.WriteLine("Database teardown");
        }
    }
}
