using TestProject.xUnit.TestFixtures;

namespace TestProject.xUnit.UnitTests.TestCollections
{
    [CollectionDefinition("Complex Collection")]
    public class ComplexCollection : ICollectionFixture<DatabaseFixture>, ICollectionFixture<AnotherFixture>
    {
    }

}
