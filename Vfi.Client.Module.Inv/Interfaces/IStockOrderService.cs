
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.Inv;

namespace Vfi.Client.Module.Inv.Interfaces
{
    public interface IStockOrderService
    {
        #region StockOrderType

        IEnumerable<StockOrderType> GetAllStockOrderTypes();
        IEnumerable<StockOrderTypeDomainModel> GetAllStockOrderTypeDomainModels();
        StockOrderType GetStockOrderTypeById(int stockOrderTypeId);
        IEnumerable<StockOrderType> GetStockOrderTypeByEoI(bool eoi);

        string CreateStockOrderType(StockOrderType stockOrderType);
        string UpdateStockOrderType(StockOrderType stockOrderType);

        #endregion

        #region StockOrder

        IEnumerable<StockOrder> GetAllStockOrders();
        IEnumerable<StockOrderDomainModel> GetAllStockOrderDomainModels();
        StockOrder GetStockOrderById(long stockOrderId);
        IEnumerable<StockOrder> GetStockOrderByStockOrderTypeId(int stockOrderTypeId);
        IEnumerable<StockOrder> GetStockOrderByWarehouseIssueId(int warehouseIssueId);
        IEnumerable<StockOrder> GetStockOrderByWarehouseReceiptId(int warehouseReceiptId);
        StockOrder GetStockOrderByCode(string stockOrderCode);
        IEnumerable<StockOrder> GetStockOrderByMoP(bool mop);
        IEnumerable<StockOrder> GetStockOrderByStatus(byte status);

        IEnumerable<StockOrderDomainModel> ConvertStockOrderToModels(IEnumerable<StockOrder> stockOrders);

        string CreateStockOrder(StockOrder stockOrder);
        string UpdateStockOrder(StockOrder stockOrder);
        string UpdateStatusStockOrder(long[] stockOrderIds, byte status, string modifiedUser);

        #endregion

        #region StockOrderDetail

        IEnumerable<StockOrderDetail> GetAllStockOrderDetails();
        IEnumerable<StockOrderDetailDomainModel> GetAllStockOrderDetailDomainModels();
        StockOrderDetail GetStockOrderDetailById(long stockOrderDetailId);
        IEnumerable<StockOrderDetail> GetStockOrderDetailByStockOrderId(long stockOrderId);

        IEnumerable<StockOrderDetailDomainModel> ConvertStockOrderDetailToModels(
            IEnumerable<StockOrderDetail> stockOrderDetails);

        #endregion
    }
}
