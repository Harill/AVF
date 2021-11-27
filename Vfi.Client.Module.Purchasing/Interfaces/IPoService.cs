
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.Purchasing;

namespace Vfi.Client.Module.Purchasing.Interfaces
{
    public interface IPoService
    {
        #region PO

        IEnumerable<PurchaseOrder> GetAllPurchaseOrders();
        IEnumerable<PurchaseOrderDomainModel> GetAllPurchaseOrderDomainModels();
        PurchaseOrder GetPurchaseOrderById(long purchaseOrderId);
        PurchaseOrder GetPurchaseOrderByRevisionNumber(string revisionNumber);
        IEnumerable<PurchaseOrder> GetPurchaseOrderByStatus(byte status);

        IEnumerable<PurchaseOrderDomainModel> ConvertPurchaseOrderToModels(IEnumerable<PurchaseOrder> purchaseOrders);

        string CreatePurchaseOrder(PurchaseOrder purchaseOrder);
        string UpdatePurchaseOrder(PurchaseOrder purchaseOrder);

        #endregion 

        #region PO Details

        PurchaseOrderDetail GetPoDetailByDetailId(long poDetailId);
        IEnumerable<PurchaseOrderDetail> GetPoDetailByPoId(long poId);

        IEnumerable<PurchaseOrderDetailDomainModel> ConvertPurchaseOrderDetailToModels(IEnumerable<PurchaseOrderDetail> purchaseOrderDetails);

        #endregion
    }
}
