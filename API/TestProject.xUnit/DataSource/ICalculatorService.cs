﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.xUnit.DataSource
{
    public interface ICalculatorService
    {
        double Add(double x1, double x2);
        double Subtract(double x1, double x2);
        double Multiply(double x1, double x2);
        double Divide(double x1, double x2);
    }

    public class CalculatorService : ICalculatorService
    {
        public double Add(double x1, double x2)
        {
            return (x1 + x2);
        }

        public double Divide(double x1, double x2)
        {
            if (x2 == 0)
            {
                throw new DivideByZeroException("x2 cannot be zero");
            }
            return (x1 / x2);
        }

        public double Multiply(double x1, double x2)
        {
            return (x1 * x2);
        }

        public double Subtract(double x1, double x2)
        {
            return (x1 - x2);
        }
    }
}
