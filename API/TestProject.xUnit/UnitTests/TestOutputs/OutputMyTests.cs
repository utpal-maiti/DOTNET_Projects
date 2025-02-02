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
        [Fact]
        public void Test2()
        {
            _output.WriteLine("Running Test2");
            int a = 5;
            int b = 3;
            _output.WriteLine($"Values: a = {a}, b = {b}");
            Assert.Equal(8, a + b);
        }
    }
}
