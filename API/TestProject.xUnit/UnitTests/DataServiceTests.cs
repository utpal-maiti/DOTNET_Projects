using Moq;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TestProject.xUnit.DataSource;

namespace TestProject.xUnit.UnitTests
{
    public class DataServiceTests
    {
        [Fact]
        public void TestDataProcessing()
        {
            // Arrange
            var mockDataSource = new Mock<IDataSource>();
            mockDataSource.Setup(d => d.GetData()).Returns("HELLO, I AM ZIGGY RAFIQ");

            var dataService = new DataService(mockDataSource.Object);

            // Act
            string result = dataService.ProcessData();

            // Assert
            Assert.Equal("HELLO, I AM ZIGGY RAFIQ", result);
        }
    }
}
