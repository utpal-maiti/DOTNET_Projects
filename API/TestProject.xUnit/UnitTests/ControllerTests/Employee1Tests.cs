using APIConcepts.Controllers;
using APIConcepts.Models;
using Moq;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TestProject.xUnit.DataSource;

namespace TestProject.xUnit.UnitTests.ControllerTests
{
    public class Employee1Tests
    {
        #region Property  
        public Mock<IEmployeeService> mock = new Mock<IEmployeeService>();
        #endregion

        [Fact]
        public async Task GetEmployeebyId()
        {
            mock.Setup(p => p.GetEmployeebyId(1)).ReturnsAsync("JK");
            Employee1Controller emp = new Employee1Controller(mock.Object);
            string result = await emp.GetEmployeeById(1);
            Assert.Equal("JK", result);
        }
        [Fact]
        public async Task GetEmployeeDetails()
        {
            var employeeDTO = new Employee()
            {
                EmployeeId = 1,
                Name = "JK",
                Desgination = "SDE"
            };
            mock.Setup(p => p.GetEmployeeDetails(1)).ReturnsAsync(employeeDTO);
            Employee1Controller emp = new Employee1Controller(mock.Object);
            var result = await emp.GetEmployeeDetails(1);
            Assert.True(employeeDTO.Equals(result));
        }
    }
}
