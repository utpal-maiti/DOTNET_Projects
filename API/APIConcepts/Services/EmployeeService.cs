using APIConcepts.Models;
using APIConcepts.Services;

using Microsoft.EntityFrameworkCore;

namespace TestProject.xUnit.DataSource
{
    public class EmployeeService : IEmployeeService
    {
        #region Property  
        private readonly ApplicationContext _appDbContext;
        #endregion

        #region Constructor  
        public EmployeeService(ApplicationContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        #endregion

        public async Task<string> GetEmployeebyId(int EmpID)
        {
            var name = await _appDbContext.Employees
                .Where(c => c.EmployeeId == EmpID)
                .Select(d => d.Name)
                .FirstOrDefaultAsync();
            return name!;
        }

        public async Task<Employee> GetEmployeeDetails(int EmpID)
        {
            var emp = await _appDbContext.Employees
                .FirstOrDefaultAsync(c => c.EmployeeId == EmpID);
            return emp!;
        }
    }
}
