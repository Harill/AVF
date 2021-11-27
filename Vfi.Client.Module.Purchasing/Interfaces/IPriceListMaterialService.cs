
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.Purchasing;

namespace Vfi.Client.Module.Purchasing.Interfaces
{
    public interface IPriceListMaterialService
    {
        IEnumerable<PriceListMaterial> GetAllPriceListMaterials();
        IEnumerable<PriceListMaterialDomainModel> GetAllPriceListMaterialModels();
        PriceListMaterial GetPriceListMaterialById(long priceListMaterialId);
        PriceListMaterial GetPriceListMaterialByMaterialId(int materialId);

        string CreatePriceListMaterial(PriceListMaterial priceListMaterial);
        string UpdatePriceListMaterial(PriceListMaterial priceListMaterial);
    }
}
