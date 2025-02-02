using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TestProject.xUnit.TestFixtures;

using Xunit.Abstractions;

namespace TestProject.xUnit.UnitTests
{
    [Collection("My Collection")]
    public class TestClass1
    {
        private readonly MyFixture _fixture;
        private readonly ITestOutputHelper _output;

        public TestClass1(MyFixture fixture, ITestOutputHelper output)
        {
            _fixture = fixture;
            _output = output;
        }

        [Fact]
        public void Test1()
        {
            _output.WriteLine("Running Test1");
            Assert.True(true);
        }

        [Fact]
        public void Test2()
        {
            _output.WriteLine("Running Test2");
            Assert.True(true);
        }

        [Fact]
        public void TestWithConditionalLogging()
        {
            int a = 5;
            int b = 3;
            if (a + b != 8)
            {
                _output.WriteLine("Unexpected result: a + b is not equal to 8");
            }
            Assert.Equal(8, a + b);
        }
    }




}
