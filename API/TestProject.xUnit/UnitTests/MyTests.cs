using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.xUnit.UnitTests
{
    public class MyTests : IClassFixture<MyTestFixture>
    {
        private readonly MyTestFixture _fixture;

        public MyTests(MyTestFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Test1()
        {
            // Use _fixture in your test
            Console.WriteLine("Running Test1");
        }
        [Fact]
        public void Test2()
        {
            Console.WriteLine("Running Test2");
        }

        [Fact]
        public void TestWithoutParameters()
        {
            Assert.Equal(4, 2 + 2);
        }

        [Theory]
        [InlineData(3, 5, 8)]
        [InlineData(2, 4, 6)]
        public void TestWithParameters(int a, int b, int expected)
        {
            Assert.Equal(expected, a + b);
        }
    }
}
