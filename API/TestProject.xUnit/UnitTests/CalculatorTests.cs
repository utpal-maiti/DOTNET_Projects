using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TestProject.xUnit.DataSource;
using TestProject.xUnit;

namespace TestProject.xUnit.UnitTests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            // Arrange
            var calculator = new Calculator();
            int a = 5;
            int b = 3;

            // Act
            int result = calculator.Add(a, b);

            // Assert
            Assert.Equal(8, result);
        }

        [Theory]
        [InlineData(5, 3, 8)]
        [InlineData(-1, 1, 0)]
        [InlineData(-1, -1, -2)]
        public void Add_ReturnsCorrectSumTheory(int a, int b, int expected)
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            int result = calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, result);
        }



        public static IEnumerable<object[]> Data =>
    new List<object[]>
    {
        new object[] { 3, 5, 8 },
        new object[] { 2, 4, 6 },
        new object[] { -1, -1, -2 }
    };

        [Theory]
        [MemberData(nameof(Data))]
        public void Add_ReturnsCorrectSumMemberData(int a, int b, int expected)
        {
            var calculator = new Calculator();
            int result = calculator.Add(a, b);
            Assert.Equal(expected, result);
        }

        public class TestData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { 3, 5, 8 };
                yield return new object[] { 2, 4, 6 };
                yield return new object[] { -1, -1, -2 };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        [Theory]
        [ClassData(typeof(TestData))]
        public void Add_ReturnsCorrectSumClassData(int a, int b, int expected)
        {
            var calculator = new Calculator();
            int result = calculator.Add(a, b);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Subtract_ReturnsCorrectDifference()
        {
            // Arrange
            var calculator = new Calculator();
            int a = 5;
            int b = 3;

            // Act
            int result = calculator.Subtract(a, b);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void TestAddition()
        {
            // Arrange
            int a = 2;
            int b = 3;

            // Act
            int result = a + b;

            // Assert
            Assert.Equal(5, result);
        }
        [Fact]
        public void TestSubtraction()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = a - b;

            // Assert
            Assert.Equal(2, result);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(5, 4, 20)]
        [InlineData(0, 7, 0)]
        public void TestMultiplication(int a, int b, int expected)
        {
            // Act
            int result = a * b;

            // Assert
            Assert.Equal(expected, result);
        }



    }
}
