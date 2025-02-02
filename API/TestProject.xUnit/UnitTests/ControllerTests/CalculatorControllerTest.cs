﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TestProject.xUnit.DataSource;

namespace TestProject.xUnit.UnitTests.ControllerTests
{
    public class CalculatorControllerTest
    {
        private CalculatorService _unitTesting;

        public CalculatorControllerTest()
        {
            if (_unitTesting == null)
            {
                _unitTesting = new CalculatorService();
            }
        }

        [Fact]
        public void Add()
        {
            //arrange
            double a = 5;
            double b = 3;
            double expected = 8;

            //act
            var actual = _unitTesting.Add(a, b);

            //Assert
            Assert.Equal(expected, actual, 0);
        }
        [Fact]
        public void Substract()
        {
            //arrange
            double x1 = 10;
            double x2 = 8;
            double expected = 2;

            //act
            var actual = _unitTesting.Subtract(x1, x2);

            //assert
            Assert.Equal(expected, actual, 0);
        }
        [Theory(DisplayName = "Maths- Divided with parameters")]
        [InlineData(40, 8, 5)]
        public void Divide(double value1, double value2, double value3)
        {
            //arrange
            double x1 = value1;
            double x2 = value2;
            double expected = value3;

            //act
            var actual = _unitTesting.Divide(x1, x2);

            //assert
            Assert.Equal(expected, actual, 0);
        }
        [Fact(Skip = "Do not run now")]
        public void Multiply()
        {
            //arrange
            double x1 = 5;
            double x2 = 8;
            double expected = 40;

            //act
            var actual = _unitTesting.Multiply(x1, x2);

            //assert
            Assert.Equal(expected, actual, 0);
        }
        [Fact(DisplayName = "Maths - Divide by Zero Exception")]
        public void DivideByZeroException()
        {
            //arrange
            double a = 100;
            double b = 0;

            //act
            Action act = () => _unitTesting.Divide(a, b);

            //assert
            Assert.Throws<DivideByZeroException>(act);
        }
    }
}
