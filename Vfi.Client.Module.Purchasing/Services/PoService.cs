using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.Unity;
using Vfi.Client.Module.Purchasing.Interfaces;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.Production;
using Vfi.Server.Core.DataModel.Models.Purchasing;
using Vfi.Server.Core.Repository.Purchasing;

namespace Vfi.Client.Module.Purchasing.Services
{
    public class PoService: IPoService
    {
        private readonly IPurchaseOrderRepository _purchaseOrderRepository;
        private readonly IPurchaseOrderDetailRepository _purchaseOrderDetailRepository;
        [InjectionConstructor]
        public PoService(IPurchaseOrderRepository purchaseOrderRepository, 
                            IPurchaseOrderDetailRepository purchaseOrderDetailRepository)
        {
            if (purchaseOrderRepository == null) throw new ArgumentNullException("purchaseOrderRepository");
            if (purchaseOrderDetailRepository == null) throw new ArgumentNullException("purchaseOrderDetailRepository");

            _purchaseOrderRepository = purchaseOrderRepository;
            _purchaseOrderDetailRepository = purchaseOrderDetailRepository;
        }

        #region PO

        public IEnumerable<PurchaseOrder> GetAllPurchaseOrders()
        {
            try
            {
                return _purchaseOrderRepository.GetAllAsNoTracking();
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<PurchaseOrderDomainModel> GetAllPurchaseOrderDomainModels()
        {
            try
            {
                return GetAllPurchaseOrders().Select(
                    entity => new PurchaseOrderDomainModel
                                  {
                                      PurchaseOrderId = entity.PurchaseOrderId,
                                      VendorId = entity.VendorId,
                                      VendorName = entity.Vendor != null ? entity.Vendor.VendorName : "",
                                      VendorCode = entity.Vendor != null ? entity.Vendor.VendorCode : "",

                                      ShipMethodId = entity.ShipMethodId,
                                      ShipMethodName = entity.ShipMethod != null ? entity.ShipMethod.Name : "",

                                      EmployeeId = entity.EmployeeId,
                                      EmployeeName = entity.Employee != null ? entity.Employee.EmployeeName : "",

                                      RevisionNumber = entity.RevisionNumber,
                                      Status = entity.Status,
                                      StatusName = CastStatusEnumDomain.GetTextStatusEnumDomain(entity.Status),
                                      
                                      OrderDate = entity.OrderDate,
                                      ShipDate = entity.ShipDate,
                                      
                                      SubTotal = entity.SubTotal,
                                      TaxAmt = entity.TaxAmt,
                                      Freight = entity.Freight,
                                      TotalDue = entity.TotalDue,

                                      Active = entity.Active,
                                      ModifiedUser = entity.ModifiedUser,
                                      //ModifiedDate = entity.ModifiedDate
                                  });
            }
            catch
            {
                return null;
            }
        }
        public PurchaseOrder GetPurchaseOrderById(long purchaseOrderId)
        {
            try
            {
                return _purchaseOrderRepository.FindAsNoTracking(f => f.PurchaseOrderId == purchaseOrderId).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        public PurchaseOrder GetPurchaseOrderByRevisionNumber(string revisionNumber)
        {
            try
            {
                return
                    _purchaseOrderRepository.FindAsNoTracking(
                        f => f.RevisionNumber.Equals(revisionNumber, StringComparison.OrdinalIgnoreCase)).FirstOrDefault
                        ();
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<PurchaseOrder> GetPurchaseOrderByStatus(byte status)
        {
            try
            {
                return _purchaseOrderRepository.FindAsNoTracking(f => f.Status == status);
            }
            catch
            {
                return null;
            }
        }

        public IEnumerable<PurchaseOrderDomainModel> ConvertPurchaseOrderToModels(IEnumerable<PurchaseOrder> purchaseOrders)
        {
            try
            {
                return purchaseOrders.Select(
                    entity => new PurchaseOrderDomainModel
                    {
                        PurchaseOrderId = entity.PurchaseOrderId,
                        VendorId = entity.VendorId,
                        VendorName = entity.Vendor != null ? entity.Vendor.VendorName : "",
                        VendorCode = entity.Vendor != null ? entity.Vendor.VendorCode : "",

                        ShipMethodId = entity.ShipMethodId,
                        ShipMethodName = entity.ShipMethod != null ? entity.ShipMethod.Name : "",

                        EmployeeId = entity.EmployeeId,
                        EmployeeName = entity.Employee != null ? entity.Employee.EmployeeName : "",

                        RevisionNumber = entity.RevisionNumber,
                        Status = entity.Status,
                        StatusName = CastStatusEnumDomain.GetTextStatusEnumDomain(entity.Status),
                        
                        OrderDate = entity.OrderDate,
                        ShipDate = entity.ShipDate,

                        SubTotal = entity.SubTotal,
                        TaxAmt = entity.TaxAmt,
                        Freight = entity.Freight,
                        TotalDue = entity.TotalDue,

                        Active = entity.Active,
                        ModifiedUser = entity.ModifiedUser,
                        //ModifiedDate = entity.ModifiedDate
                    });
            }
            catch
            {
                return null;
            }
        }

        public string CreatePurchaseOrder(PurchaseOrder purchaseOrder)
        {
            try
            {
                var targetCreate = GetPurchaseOrderByRevisionNumber(purchaseOrder.RevisionNumber);
                if(targetCreate == null)
                {
                    _purchaseOrderRepository.Add(purchaseOrder);

                    var poDetails = purchaseOrder.PurchaseOrderDetails;
                    foreach (var poDetail in poDetails)
                    {
                        poDetail.PurchaseOrderId = purchaseOrder.PurchaseOrderId;
                        _purchaseOrderDetailRepository.Add(poDetail);
                    }

                    return "1";
                }
                return "0";
            }
            catch(Exception exception)
            {
                return exception.Message;
            }
        }
        public string UpdatePurchaseOrder(PurchaseOrder purchaseOrder)
        {
            try
            {
                var targetUpdate =
                    _purchaseOrderRepository.Find(
                        f =>
                        f.PurchaseOrderId == purchaseOrder.PurchaseOrderId &&
                        f.RevisionNumber == purchaseOrder.RevisionNumber).FirstOrDefault();
                if (targetUpdate != null)
                {
                    targetUpdate.VendorId = purchaseOrder.VendorId;
                    targetUpdate.ShipMethodId = purchaseOrder.ShipMethodId;
                    targetUpdate.EmployeeId = purchaseOrder.EmployeeId;

                    targetUpdate.Status = purchaseOrder.Status;
                    targetUpdate.OrderDate = purchaseOrder.OrderDate;
                    targetUpdate.ShipDate = purchaseOrder.ShipDate ?? targetUpdate.ShipDate;
                    targetUpdate.SubTotal = purchaseOrder.SubTotal;
                    targetUpdate.TaxAmt = purchaseOrder.TaxAmt;
                    targetUpdate.Freight = purchaseOrder.Freight;
                    targetUpdate.TotalDue = purchaseOrder.TotalDue;

                    targetUpdate.Active = purchaseOrder.Active;
                    targetUpdate.ModifiedUser = purchaseOrder.ModifiedUser ?? targetUpdate.ModifiedUser;
                    targetUpdate.ModifiedDate = DateTime.Now;

                    //return "1";
                }
                return "0";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        #endregion

        #region PO Details

        public PurchaseOrderDetail GetPoDetailByDetailId(long poDetailId)
        {
            try
            {
                return _purchaseOrderDetailRepository.FindAsNoTracking(f => f.PurchaseOrderDetailId == poDetailId).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<PurchaseOrderDetail> GetPoDetailByPoId(long poId)
        {
            try
            {
                return _purchaseOrderDetailRepository.FindAsNoTracking(f => f.PurchaseOrderId == poId);
            }
            catch
            {
                return null;
            }
        }

        public IEnumerable<PurchaseOrderDetailDomainModel> 
            ConvertPurchaseOrderDetailToModels(IEnumerable<PurchaseOrderDetail> purchaseOrderDetails)
        {
            try
            {
                return purchaseOrderDetails.Select(
                    entity => new PurchaseOrderDetailDomainModel
                                  {
                                      PurchaseOrderDetailId = entity.PurchaseOrderDetailId,
                                      PurchaseOrderId = entity.PurchaseOrderId,
                                      
                                      MaterialId = entity.MaterialId,
                                      MaterialCode = entity.Material != null ? entity.Material.MaterialCode : "",
                                      MaterialName = entity.Material != null ? entity.Material.MaterialName : "",

                                      OrderQty = entity.OrderQty,
                                      UnitPrice = entity.UnitPrice,
                                      LineTotal = entity.LineTotal
                                  });
            }
            catch
            {
                return null;
            }
        }

        #endregion
    }
}
