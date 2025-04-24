using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TestProject.xUnit.DataSource;

namespace TestProject.xUnit.TestFixtures
{
    public class CalculatorFixture : IDisposable
    {
        public Calculator Calculator { get; private set; }

        public CalculatorFixture()
        {
            // Initialize resources, create instances, etc.
            Calculator = new Calculator();
        }

        public void Dispose()
        {
            // Clean up resources, dispose of instances, etc.
            Calculator.Dispose();
        }
    }
}
