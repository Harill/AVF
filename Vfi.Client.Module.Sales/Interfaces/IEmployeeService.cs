
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.Sales;

namespace Vfi.Client.Module.Sales.Interfaces
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAllEmployees();
        IEnumerable<EmployeeDomainModel> GetAllEmployeeDomainModel();
        Employee GetEmployeeById(int employeeId);
        Employee GetEmployeeByCode(string employeeCode);
        bool CheckEmployeeCodeByOwn(int employeeId, string employeeCode);

        string CreateEmployee(Employee employee);
        string UpdateEmployee(Employee employee);
    }
}
