
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.Inv;

namespace Vfi.Client.Module.Inv.Interfaces
{
    public interface IMaterialInventoryService
    {
        IEnumerable<MaterialInventory> GetAllMaterialInventories();
        IEnumerable<MaterialInventoryDomainModel> GetAllMaterialInventoryDomainModels();
        IEnumerable<MaterialInventoryDomainModel> ConvertMaterialInventoryToModels(IEnumerable<MaterialInventory> materialInventories);

        MaterialInventory GetMaterialInventoryById(long materialInventoryId);
        IEnumerable<MaterialInventory> GetMaterialInventoryByMaterialId(int materialId);
        IEnumerable<MaterialInventory> GetMaterialInventoryByWarehouseId(int warehouseId);
        MaterialInventory GetMaterialInventory(int? materialId, int? warehouseId);
        IEnumerable<MaterialInventory> GetMaterialInventoryByStatus(byte status);

        string CreateMaterialInventory(MaterialInventory materialInventory);
        string UpdateMaterialInventory(MaterialInventory materialInventory);

        string ImportMaterialInventory(MaterialInventory materialInventory);
        string ImportMaterialInventories(IEnumerable<MaterialInventory> materialInventories);

        string ExportMaterialInventories(IEnumerable<MaterialInventory> materialInventories);

        string RotateMaterialInventories(IEnumerable<MaterialInventory> materialInventoryIssues
                                         , IEnumerable<MaterialInventory> materialInventoryReceipts);
    }
}
