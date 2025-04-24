using TestProject.xUnit.TestFixtures;

namespace TestProject.xUnit.UnitTests.TestCollections
{
    [CollectionDefinition("My Collection")]
    public class MyCollection : ICollectionFixture<MyFixture>
    {
    }

}
