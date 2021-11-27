using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.Unity;
using Vfi.Client.Module.Purchasing.Interfaces;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.Purchasing;
using Vfi.Server.Core.Repository.Purchasing;

namespace Vfi.Client.Module.Purchasing.Services
{
    public class VendorService: IVendorService
    {
        private readonly IVendorRepository _vendorRepository;
        [InjectionConstructor]
        public VendorService(IVendorRepository vendorRepository)
        {
            if (vendorRepository == null) throw new ArgumentNullException("vendorRepository");
            _vendorRepository = vendorRepository;
        }

        #region Vendor

        public IEnumerable<Vendor> GetAllVendors()
        {
            try
            {
                return _vendorRepository.GetAllAsNoTracking();
            }
            catch (Exception)
            {
                return null;
            }
        }
        public IEnumerable<VendorDomainModel> ConvertVendorToModels(IEnumerable<Vendor> vendors)
        {
            try
            {
                return vendors.Select(
                    entity => new VendorDomainModel
                    {
                        VendorId = entity.VendorId,
                        VendorCode = entity.VendorCode,
                        VendorName = entity.VendorName,
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
                    });
            }
            catch (Exception)
            {
                return null;
            }
        }
        public Vendor GetVendorById(int vendorId)
        {
            try
            {
                return _vendorRepository.FindAsNoTracking(f => f.VendorId == vendorId).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
        }
        public Vendor GetVendorByCode(string vendorCode)
        {
            try
            {
                return
                    _vendorRepository.FindAsNoTracking(
                        f => f.VendorCode.Equals(vendorCode, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
        }
        public bool CheckVendorCodeByOwn(int vendorId, string vendorCode)
        {
            try
            {
                var result = _vendorRepository.Find(
                    f => f.VendorId != vendorId &&
                    f.VendorCode.Equals(vendorCode, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
                return result != null;
            }
            catch (Exception)
            {
                throw new ArgumentNullException("vendorCode");
            }
        }

        public string CreateVendor(Vendor vendor)
        {
            try
            {
                var targetCreate = GetVendorByCode(vendor.VendorCode);
                if (targetCreate == null)
                {
                    _vendorRepository.Add(vendor);
                    return "1";
                }
                return "0";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        public string UpdateVendor(Vendor vendor)
        {
            try
            {
                var targetUpdate =
                    _vendorRepository.Find(f => f.VendorId == vendor.VendorId).FirstOrDefault();
                if (targetUpdate != null)
                {
                    targetUpdate.VendorCode = vendor.VendorCode ?? targetUpdate.VendorCode;
                    targetUpdate.VendorName = vendor.VendorName ?? targetUpdate.VendorName;
                    targetUpdate.ShortName = vendor.ShortName ?? targetUpdate.ShortName;
                    targetUpdate.CompanyName = vendor.CompanyName ?? targetUpdate.CompanyName;
                    targetUpdate.ContactName = vendor.ContactName ?? targetUpdate.ContactName;
                    targetUpdate.Address = vendor.Address ?? targetUpdate.Address;
                    targetUpdate.Eaddress = vendor.Eaddress ?? targetUpdate.Eaddress;
                    targetUpdate.Phone = vendor.Phone ?? targetUpdate.Phone;
                    targetUpdate.Fax = vendor.Fax ?? targetUpdate.Fax;
                    targetUpdate.Email = vendor.Email ?? targetUpdate.Email;
                    targetUpdate.TaxCode = vendor.TaxCode ?? targetUpdate.TaxCode;
                    targetUpdate.BankAccount = vendor.BankAccount ?? targetUpdate.BankAccount;
                    targetUpdate.MaxCredit = vendor.MaxCredit ?? targetUpdate.MaxCredit;
                    targetUpdate.SpecialInfo = vendor.SpecialInfo ?? targetUpdate.SpecialInfo;
                    targetUpdate.Note = vendor.Note ?? targetUpdate.Note;

                    targetUpdate.Active = vendor.Active;
                    targetUpdate.ModifiedUser = vendor.ModifiedUser ?? targetUpdate.ModifiedUser;
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
        
        #endregion
    }
}
