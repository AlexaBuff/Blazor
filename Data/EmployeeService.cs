using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUD.Data
{
    public class EmployeeService
    {
        #region Property
        private readonly AppDBContext _appDBContext;
        #endregion
       
        #region Constructor
        public EmployeeService(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

      
        public Task<List<Employee>> GetAllEmployeesAsync()        
        {
           
            return Task.FromResult(_appDBContext.Employees.ToList());
        }      
        public async Task<string> InsertEmployeeAsync(Employee employee)
        {

            _appDBContext.Add(employee);
           await _appDBContext.SaveChangesAsync();           
            return "Success";
        }
       
        #region Get Employee by Id0
        public async Task<Employee> GetEmployeeAsync(int Id)
        {
            Employee employee = await _appDBContext.Employees.FirstOrDefaultAsync(c => c.IdEmp.Equals(Id));
            return employee;
        }
        #endregion

        #region Update Employee
        public async Task<string> UpdateEmployeeAsync(Employee employee)
        {
             _appDBContext.Update(employee);
            await _appDBContext.SaveChangesAsync();
            return "Success";
        }
        #endregion

        #region DeleteEmployee
        public async Task<string> DeleteEmployeeAsync(long id)
        {

            var employee = await _appDBContext.Employees.FindAsync(id);
            _appDBContext.Remove(employee);
            await _appDBContext.SaveChangesAsync();
            return "Success";
        }
        #endregion
    }
}
