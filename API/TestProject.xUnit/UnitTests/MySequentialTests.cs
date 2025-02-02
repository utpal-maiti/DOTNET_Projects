using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.xUnit.UnitTests
{
    [Collection("Sequential Tests")]
#pragma warning disable CS0657 // Not a valid attribute location for this declaration
    [assembly: CollectionBehavior(CollectionBehavior.CollectionPerClass, MaxParallelThreads = 4)]
#pragma warning restore CS0657 // Not a valid attribute location for this declaration
    public class MySequentialTests
    {
        [Fact]
        public void Test1()
        {
            // Test code here
        }

        [Fact]
        public void Test2()
        {
            // Test code here
        }
    }
}
