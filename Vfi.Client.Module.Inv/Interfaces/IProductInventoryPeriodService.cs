
using System;
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.Inv;

namespace Vfi.Client.Module.Inv.Interfaces
{
    public interface IProductInventoryPeriodService
    {
        IEnumerable<ProductInventoryPeriod> GetAllProductInventoryPeriods();
        IEnumerable<ProductInventoryPeriodDomainModel> GetAllProductInventoryPeroidDomainModels();
        IEnumerable<ProductInventoryPeriod> GetProductInventoryPeriodByTransactionId(long transactionId);
        IEnumerable<ProductInventoryPeriod> GetProductInventoryPeriodByProductId(int productId);
        IEnumerable<ProductInventoryPeriod> GetProductInventoryPeriodByWarehouseId(int warehouseId);
        IEnumerable<ProductInventoryPeriod> GetProductInventoryPeriods(int productId, int warehouseId);

        IEnumerable<ProductInventoryPeriod> GetAllProductInventoryPeriodsByDate(int day, int month, int year);

        string CreateProductInventoryPeriod(ProductInventoryPeriod productInventoryPeriod);
        string UpdateProductInventoryPeriod(ProductInventoryPeriod productInventoryPeriod);

        string ImportProductInventoryPeriods(IEnumerable<ProductInventoryPeriod> productInventoryPeriods);
        string ExportProductInventoryPeriods(IEnumerable<ProductInventoryPeriod> productInventoryPeriods);

        string RotateProductInventoryPeriods(IEnumerable<ProductInventoryPeriod> productInventoryPeriodIssues,
                                              IEnumerable<ProductInventoryPeriod> productInventoryPeriodReceipts);
    }
}
