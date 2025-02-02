using TestProject.xUnit.TestFixtures;

namespace TestProject.xUnit.UnitTests.TestCollections
{
    [CollectionDefinition("Non-Parallel Collection", DisableParallelization = true)]
    public class NonParallelCollection : ICollectionFixture<DatabaseFixture>
    {
    }

}
