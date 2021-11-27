
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.Inv;

namespace Vfi.Client.Module.Inv.Interfaces
{
    public interface IMaterialInventoryPeriodService
    {
        IEnumerable<MaterialInventoryPeriod> GetAllMaterialInventoryPeriods();
        IEnumerable<MaterialInventoryPeriodDomainModel> GetAllMaterialInventoryPeroidDomainModels();
        IEnumerable<MaterialInventoryPeriod> GetMaterialInventoryPeriodByTransactionId(long transactionId);
        IEnumerable<MaterialInventoryPeriod> GetMaterialInventoryPeriodByMaterialId(int materialId);
        IEnumerable<MaterialInventoryPeriod> GetMaterialInventoryPeriodByWarehouseId(int warehouseId);
        IEnumerable<MaterialInventoryPeriod> GetMaterialInventoryPeriods(int materialId, int warehouseId);

        string CreateMaterialInventoryPeriod(MaterialInventoryPeriod materialInventoryPeriod);
        string UpdateMaterialInventoryPeriod(MaterialInventoryPeriod materialInventoryPeriod);

        string ImportMaterialInventoryPeriods(IEnumerable<MaterialInventoryPeriod> materialInventoryPeriods);
        string ExportMaterialInventoryPeriods(IEnumerable<MaterialInventoryPeriod> materialInventoryPeriods);

        string RotateMaterialInventoryPeriods(IEnumerable<MaterialInventoryPeriod> materialInventoryPeriodIssues,
                                              IEnumerable<MaterialInventoryPeriod> materialInventoryPeriodReceipts);
    }
}
