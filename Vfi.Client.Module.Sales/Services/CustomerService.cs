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
    public class CustomerService: ICustomerService
    {
        private readonly ICustomerTypeRepository _customerTypeRepository;
        private readonly ICustomerRepository _customerRepository;
        [InjectionConstructor]
        public CustomerService(ICustomerTypeRepository customerTypeRepository, ICustomerRepository customerRepository)
        {
            if (customerTypeRepository == null) throw new ArgumentNullException("customerTypeRepository");
            if (customerRepository == null) throw new ArgumentNullException("customerRepository");

            _customerTypeRepository = customerTypeRepository;
            _customerRepository = customerRepository;
        }

        #region CustomerType

        public IEnumerable<CustomerType> GetAllCustomerTypes()
        {
            try
            {
                return _customerTypeRepository.GetAllAsNoTracking();
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<CustomerTypeDomainModel> ConvertCustomerTypeToModels(IEnumerable<CustomerType> customerTypes)
        {
            try
            {
                return customerTypes.Select(
                    entity => new CustomerTypeDomainModel
                                  {
                                      CustomerTypeId = entity.CustomerTypeId,
                                      CustomerTypeName = entity.CustomerTypeName,
                                      Note = entity.Note,
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
        public CustomerType GetCustomerTypeById(int customerTypeId)
        {
            try
            {
                return _customerTypeRepository.FindAsNoTracking(f => f.CustomerTypeId == customerTypeId).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }

        public string CreateCustomerType(CustomerType customerType)
        {
            try
            {
                var targetCreate = GetCustomerTypeById(customerType.CustomerTypeId);
                if(targetCreate == null)
                {
                    _customerTypeRepository.Add(customerType);

                    return "1";
                }
                return "0";
            }
            catch(Exception exception)
            {
                return exception.Message;
            }
        }
        public string UpdateCustomerType(CustomerType customerType)
        {
            try
            {
                var targetUpdate =
                    _customerTypeRepository.Find(f => f.CustomerTypeId == customerType.CustomerTypeId).FirstOrDefault();
                if(targetUpdate != null)
                {
                    targetUpdate.CustomerTypeName = customerType.CustomerTypeName ?? customerType.CustomerTypeName;
                    targetUpdate.Note = customerType.Note ?? customerType.Note;
                    targetUpdate.Active = customerType.Active;
                    targetUpdate.ModifiedUser = customerType.ModifiedUser ?? targetUpdate.ModifiedUser;
                    targetUpdate.ModifiedDate = DateTime.Now;

                    return "1";
                }
                return "0";
            }
            catch(Exception exception)
            {
                return exception.Message;
            }
        }

        #endregion

        #region Customer

        public IEnumerable<Customer> GetAllCustomers()
        {
            try
            {
                return _customerRepository.GetAllAsNoTracking();
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<CustomerDomainModel> ConvertCustomerToModels(IEnumerable<Customer> customers)
        {
            try
            {
                return customers.Select(
                    entity => new CustomerDomainModel
                                  {
                                      CustomerId = entity.CustomerId,
                                      CustomerTypeId = entity.CustomerTypeId,
                                      CustomerTypeName = entity.CustomerType != null ? entity.CustomerType.CustomerTypeName : "",

                                      CustomerCode = entity.CustomerCode,
                                      CustomerName = entity.CompanyName,
                                      ShortName = entity.ShortName,
                                      CompanyName = entity.CompanyName,
                                      ContactName = entity.ContactName,
                                      Address = entity.Address,
                                      Eaddress = entity.Eaddress,
                                      Phone = entity.Phone,
                                      Fax = entity.Fax,
                                      Email = entity.Email,
                                      TaxCode = entity.TaxCode,
                                      BankAccount = entity.BankAccount,
                                      MaxCredit = entity.MaxCredit,
                                      SpecialInfo = entity.SpecialInfo,
                                      Note = entity.Note,
                                      
                                      Active = entity.Active,
                                      ModifiedUser = entity.ModifiedUser,
                                      ModifiedDate = entity.ModifiedDate
                                  }).OrderBy(f=>f.CustomerCode);
            }
            catch
            {
                return null;
            }
        }
        public Customer GetCustomerById(int customerId)
        {
            try
            {
                return _customerRepository.FindAsNoTracking(f => f.CustomerId == customerId).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<Customer> GetCustomerByCustomerTypeId(int customerTypeId)
        {
            try
            {
                return _customerRepository.FindAsNoTracking(f => f.CustomerTypeId == customerTypeId);
            }
            catch
            {
                return null;
            }
        }
        public Customer GetCustomerByCode(string customerCode)
        {
            try
            {
                return
                    _customerRepository.FindAsNoTracking(
                        f => f.CustomerCode.Equals(customerCode, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        public bool CheckCustomerCodeByOwn(int customerId, string cutomerCode)
        {
            try
            {
                var result = _customerRepository.Find(
                    f => f.CustomerId != customerId &&
                    f.CustomerCode.Equals(cutomerCode, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
                return result != null;
            }
            catch (Exception)
            {
                throw new ArgumentNullException("cutomerCode");
            }
        }

        public string CreateCustomer(Customer customer)
        {
            try
            {
                var targetCreate = GetCustomerById(customer.CustomerId);
                if(targetCreate == null)
                {
                    _customerRepository.Add(customer);

                    return "1";
                }
                return "0";
            }
            catch(Exception exception)
            {
                return exception.Message;
            }
        }
        public string UpdateCustomer(Customer customer)
        {
            try
            {
                var targetUpdate = _customerRepository.Find(f=>f.CustomerId == customer.CustomerId).FirstOrDefault();
                if (targetUpdate != null)
                {
                    targetUpdate.CustomerTypeId = customer.CustomerTypeId;

                    targetUpdate.CustomerCode = customer.CustomerCode;
                    targetUpdate.CustomerName = customer.CompanyName;
                    targetUpdate.ShortName = customer.ShortName;
                    targetUpdate.CompanyName = customer.CompanyName;
                    targetUpdate.ContactName = customer.ContactName;
                    targetUpdate.Address = customer.Address;
                    targetUpdate.Eaddress = customer.Eaddress;
                    targetUpdate.Phone = customer.Phone;
                    targetUpdate.Fax = customer.Fax;
                    targetUpdate.Email = customer.Email;
                    targetUpdate.TaxCode = customer.TaxCode;
                    targetUpdate.BankAccount = customer.BankAccount;
                    targetUpdate.MaxCredit = customer.MaxCredit;
                    targetUpdate.SpecialInfo = customer.SpecialInfo;
                    targetUpdate.Note = customer.Note;

                    targetUpdate.Active = customer.Active;
                    targetUpdate.ModifiedUser = customer.ModifiedUser;
                    targetUpdate.ModifiedDate = customer.ModifiedDate;

                    return "1";
                }
                return "0";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        #endregion
    }
}
