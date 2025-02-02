using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TestProject.xUnit.TestFixtures;

namespace TestProject.xUnit.UnitTests
{
    [Collection("My Collection")]
    public class TestClass1
    {
        private readonly MyFixture _fixture;

        public TestClass1(MyFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Test1()
        {
            Console.WriteLine("Running TestClass1.Test1");
        }
    }




}
