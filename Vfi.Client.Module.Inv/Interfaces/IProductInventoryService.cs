
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.Inv;

namespace Vfi.Client.Module.Inv.Interfaces
{
    public interface IProductInventoryService
    {
        IEnumerable<ProductInventory> GetAllProductInventories();
        IEnumerable<ProductInventoryDomainModel> GetAllProductInventoryDomainModels();
        ProductInventory GetProductInventoryById(long productInventoryId);
        IEnumerable<ProductInventory> GetProductInventoryByProductId(int productId);
        IEnumerable<ProductInventory> GetProductInventoryByWarehouseId(int warehouseId);
        ProductInventory GetProductInventory(int? productId, int? warehouseId);
        IEnumerable<ProductInventory> GetProductInventoryByStatus(byte status);

        IEnumerable<ProductInventoryDomainModel> ConvertProductInventoryToModels(
            IEnumerable<ProductInventory> productInventories);

        string CreateProductInventory(ProductInventory productInventory);
        string UpdateProductInventory(ProductInventory productInventory);

        string ImportProductInventory(ProductInventory productInventory);
        string ImportProductInventories(IEnumerable<ProductInventory> productInventories);

        string ExportProductInventories(IEnumerable<ProductInventory> productInventories);

        string RotateProductInventories(IEnumerable<ProductInventory> productInventoryIssues
                                         , IEnumerable<ProductInventory> productInventoryReceipts);
    }
}
