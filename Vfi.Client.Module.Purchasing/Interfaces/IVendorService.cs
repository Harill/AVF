
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.Purchasing;

namespace Vfi.Client.Module.Purchasing.Interfaces
{
    public interface IVendorService
    {
        IEnumerable<Vendor> GetAllVendors();
        IEnumerable<VendorDomainModel> ConvertVendorToModels(IEnumerable<Vendor> vendors);
        Vendor GetVendorById(int vendorId);
        Vendor GetVendorByCode(string vendorCode);
        bool CheckVendorCodeByOwn(int vendorId, string vendorCode);

        string CreateVendor(Vendor vendor);
        string UpdateVendor(Vendor vendor);
    }
}
