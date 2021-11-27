using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.Unity;
using Vfi.Client.Module.Inv.Interfaces;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.Inv;
using Vfi.Server.Core.Repository.Inv;

namespace Vfi.Client.Module.Inv.Services
{
    public class StockOrderService: IStockOrderService
    {
        private readonly IStockOrderTypeRepository _stockOrderTypeRepository;
        private readonly IStockOrderRepository _stockOrderRepository;
        private readonly IStockOrderDetailRepository _stockOrderDetailRepository;
        [InjectionConstructor]
        public StockOrderService(IStockOrderTypeRepository stockOrderTypeRepository,
                                    IStockOrderRepository stockOrderRepository,
                                    IStockOrderDetailRepository stockOrderDetailRepository)
        {
            if (stockOrderTypeRepository == null) throw new ArgumentNullException("stockOrderTypeRepository");
            if (stockOrderRepository == null) throw new ArgumentNullException("stockOrderRepository");
            if (stockOrderDetailRepository == null) throw new ArgumentNullException("stockOrderDetailRepository");

            _stockOrderTypeRepository = stockOrderTypeRepository;
            _stockOrderRepository = stockOrderRepository;
            _stockOrderDetailRepository = stockOrderDetailRepository;
        }

        #region StockOrderType

        public IEnumerable<StockOrderType> GetAllStockOrderTypes()
        {
            try
            {
                return _stockOrderTypeRepository.GetAllAsNoTracking();
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<StockOrderTypeDomainModel> GetAllStockOrderTypeDomainModels()
        {
            try
            {
                return GetAllStockOrderTypes().Select(
                    entity => new StockOrderTypeDomainModel
                                  {
                                      StockOrderTypeId = entity.StockOrderTypeId,
                                      StockOrderTypeName = entity.StockOrderTypeName,
                                      EoI = entity.EoI,
                                      Active = entity.Active,
                                      ModifiedUser = entity.ModifiedUser,
                                      ModifiedDate = entity.ModifiedDate
                                  });
            }
            catch
            {
                return null;
            }
        }
        public StockOrderType GetStockOrderTypeById(int stockOrderTypeId)
        {
            try
            {
                return
                    _stockOrderTypeRepository.FindAsNoTracking(f => f.StockOrderTypeId == stockOrderTypeId)
                    .FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<StockOrderType> GetStockOrderTypeByEoI(bool eoi)
        {
            try
            {
                return eoi
                           ? _stockOrderTypeRepository.FindAsNoTracking(f => f.EoI)
                           : _stockOrderTypeRepository.FindAsNoTracking(f => f.EoI == false);
            }
            catch
            {
                return null;
            }
        }

        public string CreateStockOrderType(StockOrderType stockOrderType)
        {
            try
            {
                var targetCreate = GetStockOrderTypeById(stockOrderType.StockOrderTypeId);
                if(targetCreate == null)
                {
                    _stockOrderTypeRepository.Add(stockOrderType);

                    return "1";
                }
                return "0";
            }
            catch(Exception exception)
            {
                return exception.Message;
            }
        }
        public string UpdateStockOrderType(StockOrderType stockOrderType)
        {
            try
            {
                var targetUpdate =
                    _stockOrderTypeRepository.Find(f => f.StockOrderTypeId == stockOrderType.StockOrderTypeId)
                    .FirstOrDefault();
                if (targetUpdate != null)
                {
                    targetUpdate.StockOrderTypeName = stockOrderType.StockOrderTypeName ??
                                                      targetUpdate.StockOrderTypeName;
                    targetUpdate.EoI = stockOrderType.EoI;
                    targetUpdate.Active = stockOrderType.Active;
                    targetUpdate.ModifiedDate = DateTime.Now;

                    return "1";
                }
                return "0";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        #endregion

        #region StockOrder

        public IEnumerable<StockOrder> GetAllStockOrders()
        {
            try
            {
                return _stockOrderRepository.GetAllAsNoTracking();
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<StockOrderDomainModel> GetAllStockOrderDomainModels()
        {
            try
            {
                return GetAllStockOrders().Select(
                    enity => new StockOrderDomainModel
                                 {
                                     StockOrderId = enity.StockOrderId,
                                     StockOrderCode = enity.StockOrderCode,

                                     StockOrderTypeId = enity.StockOrderTypeId,
                                     //StockOrderTypeName = enity.StockOrderType != null ? enity.StockOrderType.StockOrderTypeName : "",
                                     
                                     WarehouseIssueId = enity.WarehouseIssueId,
                                     WarehouseIssueName = enity.WarehouseIssue != null ? enity.WarehouseIssue.WarehouseName : "",

                                     WarehouseReceiptId = enity.WarehouseReceiptId,
                                     WarehouseReceiptName = enity.WarehouseReceipt != null ? enity.WarehouseReceipt.WarehouseName : "",

                                     MoP = enity.MoP,
                                     Status = enity.Status,

                                     CreatedUser = enity.CreatedUser,
                                     CreatedDate = enity.CreatedDate,
                                     ModifiedUser = enity.ModifiedUser,
                                     ModifiedDate = enity.ModifiedDate
                                 });
            }
            catch
            {
                return null;
            }
        }
        public StockOrder GetStockOrderById(long stockOrderId)
        {
            try
            {
                return _stockOrderRepository.FindAsNoTracking(f => f.StockOrderId == stockOrderId).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<StockOrder> GetStockOrderByStockOrderTypeId(int stockOrderTypeId)
        {
            try
            {
                return _stockOrderRepository.FindAsNoTracking(f => f.StockOrderTypeId == stockOrderTypeId);
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<StockOrder> GetStockOrderByWarehouseIssueId(int warehouseIssueId)
        {
            try
            {
                return _stockOrderRepository.FindAsNoTracking(f=>f.WarehouseIssueId == warehouseIssueId);
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<StockOrder> GetStockOrderByWarehouseReceiptId(int warehouseReceiptId)
        {
            try
            {
                return _stockOrderRepository.FindAsNoTracking(f => f.WarehouseIssueId == warehouseReceiptId);
            }
            catch
            {
                return null;
            }
        }
        public StockOrder GetStockOrderByCode(string stockOrderCode)
        {
            try
            {
                return
                    _stockOrderRepository.FindAsNoTracking(
                        f => f.StockOrderCode.Equals(stockOrderCode, StringComparison.OrdinalIgnoreCase))
                        .FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<StockOrder> GetStockOrderByMoP(bool mop)
        {
            try
            {
                return mop
                           ? _stockOrderRepository.FindAsNoTracking(f => f.MoP)
                           : _stockOrderRepository.FindAsNoTracking(f => f.MoP == false);
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<StockOrder> GetStockOrderByStatus(byte status)
        {
            try
            {
                return _stockOrderRepository.FindAsNoTracking(f => f.Status == status);
            }
            catch
            {
                return null;
            }
        }

        public IEnumerable<StockOrderDomainModel> ConvertStockOrderToModels(IEnumerable<StockOrder> stockOrders)
        {
            //try
            //{
            //    return stockOrders.Select(
            //        entity => new StockOrderDomainModel
            //        {
            //            StockOrderId = entity.StockOrderId,
            //            StockOrderCode = entity.StockOrderCode,

            //            StockOrderTypeId = entity.StockOrderTypeId,
            //            //StockOrderTypeName = enity.StockOrderType != null ? enity.StockOrderType.StockOrderTypeName : "",

            //            WarehouseIssueId = entity.WarehouseIssueId,
            //            WarehouseIssueName = entity.WarehouseIssue != null ? entity.WarehouseIssue.WarehouseName : "",

            //            WarehouseReceiptId = entity.WarehouseReceiptId,
            //            WarehouseReceiptName = entity.WarehouseReceipt != null ? entity.WarehouseReceipt.WarehouseName : "",

            //            EoI = entity.EoI,
            //            EoIName = CastExportOrImportEnumDomain.GetTextExportOrImportEnumDomain(entity.EoI),

            //            MoP = entity.MoP,
            //            Status = entity.Status,
            //            StatusName = CastStockOrder/StatusEnumDomain.GetTextStockOrde/rStatusEnumDomain(entity.Status),

            //            Active = entity.Active,
            //            CreatedUser = entity.CreatedUser,
            //            CreatedDate = entity.CreatedDate,
            //            ModifiedUser = entity.ModifiedUser,
            //            ModifiedDate = entity.ModifiedDate
            //        });
            //}
            //catch
            //{
                return null;
            //}
        }

        public string CreateStockOrder(StockOrder stockOrder)
        {
            try
            {
                var targetCreate = GetStockOrderByCode(stockOrder.StockOrderCode);
                if(targetCreate == null)
                {
                    _stockOrderRepository.Add(stockOrder);
                    var soDetails = stockOrder.StockOrderDetails;
                    foreach (var soDetail in soDetails)
                    {
                        soDetail.StockOrderId = stockOrder.StockOrderId;
                        _stockOrderDetailRepository.Add(soDetail);
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
        public string UpdateStockOrder(StockOrder stockOrder)
        {
            try
            {
                var targetUpdate =
                    _stockOrderRepository.Find(f => f.StockOrderId == stockOrder.StockOrderId).FirstOrDefault();
                if (targetUpdate != null)
                {

                }
                return "0";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        public string UpdateStatusStockOrder(long[] stockOrderIds, byte status, string modifiedUser)
        {
            try
            {
                var entities = _stockOrderRepository.Find(f => stockOrderIds.Contains(f.StockOrderId));
                var c = entities.Count();
                if(c <= 0 )
                    return "0";

                for (var i = 0; i < c; i++ )
                {
                    entities.ElementAt(i).Status = status;
                    entities.ElementAt(i).ModifiedUser = modifiedUser;
                    entities.ElementAt(i).ModifiedDate = DateTime.Now;
                }

                return "1";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        #endregion

        #region StockOrderDetail

        public IEnumerable<StockOrderDetail> GetAllStockOrderDetails()
        {
            try
            {
                return _stockOrderDetailRepository.GetAllAsNoTracking();
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<StockOrderDetailDomainModel> GetAllStockOrderDetailDomainModels()
        {
            try
            {
                return GetAllStockOrderDetails().Select(
                    entity => new StockOrderDetailDomainModel
                                  {
                                      StockOrderDetailId = entity.StockOrderDetailId,
                                      StockOrderId = entity.StockOrderId,
                                      ReferenceId = entity.ReferenceId,

                                      MoP = entity.MoP,
                                      Quantity = entity.Quantity,
                                      UnitMeasure = entity.UnitMeasure,
                                      ModifiedUser = entity.ModifiedUser,
                                      ModifiedDate = entity.ModifiedDate
                                  });
            }
            catch
            {
                return null;
            }
        }
        public StockOrderDetail GetStockOrderDetailById(long stockOrderDetailId)
        {
            try
            {
                return
                    _stockOrderDetailRepository.FindAsNoTracking(f => f.StockOrderDetailId == stockOrderDetailId)
                    .FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<StockOrderDetail> GetStockOrderDetailByStockOrderId(long stockOrderId)
        {
            try
            {
                return _stockOrderDetailRepository.FindAsNoTracking(f=>f.StockOrderId == stockOrderId);
            }
            catch
            {
                return null;
            }
        }

        public IEnumerable<StockOrderDetailDomainModel> ConvertStockOrderDetailToModels(
            IEnumerable<StockOrderDetail> stockOrderDetails)
        {
            try
            {
                return stockOrderDetails.Select(
                    entity =>
                        {
                            var model = new StockOrderDetailDomainModel
                                            {
                                                StockOrderDetailId = entity.StockOrderDetailId,
                                                StockOrderId = entity.StockOrderId,
                                                ReferenceId = entity.ReferenceId,
                                                
                                                MoP = entity.MoP,
                                                Quantity = entity.Quantity,
                                                
                                                UnitMeasure = entity.UnitMeasure,

                                                ModifiedUser = entity.ModifiedUser,
                                                ModifiedDate = entity.ModifiedDate
                                            };
                            if(model.MoP)
                            {
                                model.MaterialCode = entity.Material != null ? entity.Material.MaterialCode : "";
                                model.MaterialName = entity.Material != null ? entity.Material.MaterialName : "";
                            }
                            else
                            {
                                model.ProductCode = entity.Product != null ? entity.Product.ProductCode : "";
                                model.ProductName = entity.Product != null ? entity.Product.ProductName : "";
                            }

                            return model;
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
