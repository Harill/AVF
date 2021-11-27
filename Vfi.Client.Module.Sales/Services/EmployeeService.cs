using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.Unity;
using Vfi.Client.Module.Sales.Interfaces;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.Sales;
using Vfi.Server.Core.Repository.Sales;

namespace Vfi.Client.Module.Sales.Services
{
    public class EmployeeService: IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        [InjectionConstructor]
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            if (employeeRepository == null) throw new ArgumentNullException("employeeRepository");
            _employeeRepository = employeeRepository;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            try
            {
                return _employeeRepository.GetAllAsNoTracking();
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<EmployeeDomainModel> GetAllEmployeeDomainModel()
        {
            try
            {
                return GetAllEmployees().Select(
                    entity => new EmployeeDomainModel
                                  {
                                      EmployeeId = entity.EmployeeId,
                                      EmployeeCode = entity.EmployeeCode,
                                      EmployeeName = entity.EmployeeName,
                                      Active = entity.Active,
                                      ModifiedUser = entity.ModifiedUser,
                                      ModifiedDate = entity.ModifiedDate
                                  });
            }
            catch
            {
                return null;
            }
        }
        public Employee GetEmployeeById(int employeeId)
        {
            try
            {
                return _employeeRepository.FindAsNoTracking(f => f.EmployeeId == employeeId).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        public Employee GetEmployeeByCode(string employeeCode)
        {
            try
            {
                return
                    _employeeRepository.FindAsNoTracking(
                        f => f.EmployeeCode.Equals(employeeCode, StringComparison.OrdinalIgnoreCase))
                        .FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        public bool CheckEmployeeCodeByOwn(int employeeId, string employeeCode)
        {
            try
            {
                var result = _employeeRepository.Find(
                    f => f.EmployeeId != employeeId &&
                    f.EmployeeCode.Equals(employeeCode, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
                return result != null;
            }
            catch
            {
                return false;
            }
        }

        public string CreateEmployee(Employee employee)
        {
            try
            {
                var targetCreate = GetEmployeeByCode(employee.EmployeeCode);
                if(targetCreate == null)
                {
                    _employeeRepository.Add(employee);

                    return "1";
                }
                return "0";
            }
            catch(Exception exception)
            {
                return exception.Message;
            }
        }
        public string UpdateEmployee(Employee employee)
        {
            try
            {
                var targetUpdate = _employeeRepository.Find(f => f.EmployeeId == employee.EmployeeId).FirstOrDefault();
                if (targetUpdate != null)
                {
                    targetUpdate.EmployeeCode = employee.EmployeeCode ?? targetUpdate.EmployeeCode;
                    targetUpdate.EmployeeName = employee.EmployeeName ?? targetUpdate.EmployeeName;
                    targetUpdate.Active = employee.Active;
                    targetUpdate.ModifiedUser = employee.ModifiedUser ?? targetUpdate.ModifiedUser;
                    targetUpdate.ModifiedDate = DateTime.Now;

                    return "1";
                }
                return "0";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
    }
}
