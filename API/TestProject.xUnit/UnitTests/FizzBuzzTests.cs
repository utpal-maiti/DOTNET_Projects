using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TestProject.xUnit.DataSource;

namespace TestProject.xUnit.UnitTests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void Test_Fizz()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var result = fizzBuzz.Generate(3);

            // Assert
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Test_Buzz()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var result = fizzBuzz.Generate(5);

            // Assert
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void Test_FizzBuzz()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var result = fizzBuzz.Generate(15);

            // Assert
            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void Test_Number()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var result = fizzBuzz.Generate(4);

            // Assert
            Assert.Equal("4", result);
        }

        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(4, "4")]
        public void Test_FizzBuzzTheory(int number, string expected)
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var result = fizzBuzz.Generate(number);

            // Assert
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[] { 3, "Fizz" };
            yield return new object[] { 5, "Buzz" };
            yield return new object[] { 15, "FizzBuzz" };
            yield return new object[] { 4, "4" };
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void Test_FizzBuzzMemberData(int number, string expected)
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var result = fizzBuzz.Generate(number);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [ClassData(typeof(FizzBuzzTestData))]
        public void Test_FizzBuzzClass(int number, string expected)
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var result = fizzBuzz.Generate(number);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
