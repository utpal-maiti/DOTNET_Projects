using TestProject.xUnit.DataSource;
using TestProject.xUnit.TestFixtures;

namespace TestProject.xUnit.UnitTests
{
    public class CalculatorFixtureTests : IClassFixture<CalculatorFixture>
    {
        private readonly CalculatorFixture _fixture;

        public CalculatorFixtureTests(CalculatorFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void TestAddition()
        {
            // Arrange
            Calculator calculator = _fixture.Calculator;
            int a = 5;
            int b = 10;

            // Act
            int result = calculator.Add(a, b);

            // Assert
            Assert.Equal(15, result);
        }
    }
}
