using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit.Abstractions;

namespace TestProject.xUnit.UnitTests.TestOutputs
{
    public class OutputMyTests
    {
        private readonly ITestOutputHelper _output;

        public OutputMyTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void TestWithOutput()
        {
            _output.WriteLine("This is a test output message.");
            Assert.True(true);
        }
    }
}
