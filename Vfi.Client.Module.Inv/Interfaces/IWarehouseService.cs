
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.Inv;

namespace Vfi.Client.Module.Inv.Interfaces
{
    public interface IWarehouseService
    {
        #region WarehouseType

        IEnumerable<WarehouseType> GetAllWarehouseTypes();
        IEnumerable<WarehouseTypeDomainModel> GetAllWarehouseTypeDomainModels();
        WarehouseType GetWarehouseTypeById(int warehouseTypeId);

        string CreateWarehouseType(WarehouseType warehouseType);
        string UpdateWarehouseType(WarehouseType warehouseType);

        #endregion

        #region Warehouse

        IEnumerable<Warehouse> GetAllWarehouses();
        IEnumerable<WarehouseDomainModel> GetAllWarehouseDomainModels();
        Warehouse GetWarehouseById(int warehouseId);
        IEnumerable<Warehouse> GetWarehouseByWarehouseTypeId(int warehouseTypeId);

        string CreateWarehouse(Warehouse warehouse);
        string UpdateWarehouse(Warehouse warehouse);

        #endregion
    }
}
