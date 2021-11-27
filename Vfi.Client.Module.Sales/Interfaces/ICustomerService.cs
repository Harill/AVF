
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.Sales;

namespace Vfi.Client.Module.Sales.Interfaces
{
    public interface ICustomerService
    {
        #region CustomerType

        IEnumerable<CustomerType> GetAllCustomerTypes();
        IEnumerable<CustomerTypeDomainModel> ConvertCustomerTypeToModels(IEnumerable<CustomerType> customerTypes);
        CustomerType GetCustomerTypeById(int customerTypeId);

        string CreateCustomerType(CustomerType customerType);
        string UpdateCustomerType(CustomerType customerType);

        #endregion

        #region Customer

        IEnumerable<Customer> GetAllCustomers();
        IEnumerable<CustomerDomainModel> ConvertCustomerToModels(IEnumerable<Customer> customers);
        Customer GetCustomerById(int customerId);
        IEnumerable<Customer> GetCustomerByCustomerTypeId(int customerTypeId);
        Customer GetCustomerByCode(string customerCode);
        bool CheckCustomerCodeByOwn(int customerId, string cutomerCode);

        string CreateCustomer(Customer customer);
        string UpdateCustomer(Customer customer);

        #endregion
    }
}
