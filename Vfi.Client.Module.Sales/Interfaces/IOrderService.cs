
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.Sales;

namespace Vfi.Client.Module.Sales.Interfaces
{
    public interface IOrderService
    {
        #region Order

        IEnumerable<Order> GetAllOrders();
        IEnumerable<OrderDomainModel> GetAllOrderDomainModels();
        Order GetOrderById(long salesOrderId);
        IEnumerable<Order> GetOrderByCustomerId(int customerId);
        Order GetOrderByOrderNumber(string salesOrderNumber);
        Order GetOrderByPurchaseOrderNumber(string purchaseOrderNumber);
        IEnumerable<Order> GetOrderByStatus(byte status);

        string CreateOrder(Order salesOrder);
        string UpdateOrder(Order salesOrder);

        #endregion

        #region Order Detail

        IEnumerable<OrderDetail> GetAllOrderDetails();
        IEnumerable<OrderDetailDomainModel> GetAllOrderDetailDomainModels();
        OrderDetail GetOrderDetailById(long salesOrderDetailId);
        IEnumerable<OrderDetail> GetOrderDetailByOrderId(long salesOrderId);
        IEnumerable<OrderDetail> GetOrderDetailByProductId(long productId);

        #endregion
    }
}
