using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.Unity;
//using Microsoft.Practices.Unity;
using Vfi.Client.Module.Inv.Interfaces;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.Inv;
using Vfi.Server.Core.Repository.Inv;

namespace Vfi.Client.Module.Inv.Services
{
    public class ProductInventoryPeriodService : IProductInventoryPeriodService
    {
        private readonly IProductInventoryPeriodRepository _productInventoryPeriodRepository;
        [InjectionConstructor]
        public ProductInventoryPeriodService(IProductInventoryPeriodRepository productInventoryPeriodRepository)
        {
            if (productInventoryPeriodRepository == null)
                throw new ArgumentNullException("productInventoryPeriodRepository");
            _productInventoryPeriodRepository = productInventoryPeriodRepository;
        }

        #region ProductInventoryPeriod
        public IEnumerable<ProductInventoryPeriod> GetAllProductInventoryPeriods()
        {
            try
            {
                return _productInventoryPeriodRepository.GetAllAsNoTracking();
            }
            catch
            {
                return null;
            }
        }
       public IEnumerable<ProductInventoryPeriod> GetAllProductInventoryPeriodsByDate(int day,int month,int year)
        {
            try
            {


                return
                    _productInventoryPeriodRepository.GetAllAsNoTracking();
            }
            catch
            {
                return null;
            }
       }
        public IEnumerable<ProductInventoryPeriodDomainModel> GetAllProductInventoryPeroidDomainModels()
        {
            try
            {
                return GetAllProductInventoryPeriods().Select(
                    entity => new ProductInventoryPeriodDomainModel
                                  {
                                      ProductInventoryPeriodId = entity.ProductInventoryPeriodId,
                                      
                                      TransactionId = entity.TransactionId,
                                      
                                      ProductId = entity.ProductId,
                                      ProductCode = entity.Product != null ? entity.Product.ProductCode : "",
                                      ProductName = entity.Product != null ? entity.Product.ProductName : "",

                                      WarehouseId = entity.WarehouseId,
                                      WarehouseName = entity.Warehouse != null ? entity.Warehouse.WarehouseName : "",

                                      PeriodDay = entity.PeriodDay,
                                      PeriodMonth = entity.PeriodMonth,
                                      PeriodYear = entity.PeriodYear,
                                      PeriodDate = entity.PeriodDate,

                                      EarlyPeriodQuantity = entity.EarlyPeriodQuantity,
                                      EarlyPeriodPrice = entity.EarlyPeriodPrice,

                                      Quantity = entity.Quantity,
                                      UnitPrice = entity.UnitPrice,
                                      Price = entity.Price,
                                      UnitMeasure = entity.UnitMeasure,

                                      LastPeriodQuantity = entity.LastPeriodQuantity,
                                      LastPeriodPrice = entity.LastPeriodPrice,

                                      ModifiedUser = entity.ModifiedUser,
                                      ModifiedDate = entity.ModifiedDate
                                  });
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<ProductInventoryPeriod> GetProductInventoryPeriodByTransactionId(long transactionId)
        {
            try
            {
                return _productInventoryPeriodRepository.FindAsNoTracking(f => f.TransactionId == transactionId);
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<ProductInventoryPeriod> GetProductInventoryPeriodByProductId(int productId)
        {
            try
            {
                return _productInventoryPeriodRepository.FindAsNoTracking(f => f.ProductId == productId);
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<ProductInventoryPeriod> GetProductInventoryPeriodByWarehouseId(int warehouseId)
        {
            try
            {
                return _productInventoryPeriodRepository.FindAsNoTracking(f => f.WarehouseId == warehouseId);
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<ProductInventoryPeriod> GetProductInventoryPeriods(int productId, int warehouseId)
        {
            try
            {
                return
                    _productInventoryPeriodRepository.FindAsNoTracking(
                        f => f.ProductId == productId && f.WarehouseId == warehouseId);
            }
            catch
            {
                return null;
            }
        }

        public string CreateProductInventoryPeriod(ProductInventoryPeriod productInventoryPeriod)
        {
            try
            {
                return "0";
            }
            catch(Exception exception)
            {
                return exception.Message;
            }
        }
        public string UpdateProductInventoryPeriod(ProductInventoryPeriod productInventoryPeriod)
        {
            try
            {
                return "0";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string ImportProductInventoryPeriods(IEnumerable<ProductInventoryPeriod> productInventoryPeriods)
        {
            try
            {
                foreach (var productInventoryPeriod in productInventoryPeriods)
                {
                    if (productInventoryPeriod == null) break;
                    var model = productInventoryPeriod;

                    var targetImport =
                        _productInventoryPeriodRepository.FindAsNoTracking(
                            f => f.WarehouseId == model.WarehouseId && f.ProductId == model.ProductId).LastOrDefault();

                    model.EarlyPeriodQuantity = targetImport != null ? targetImport.LastPeriodQuantity : 0;
                    if (model.EarlyPeriodQuantity == null) model.EarlyPeriodQuantity = 0;
                    model.Quantity = model.Quantity;
                    model.LastPeriodQuantity = model.EarlyPeriodQuantity + model.Quantity;

                    _productInventoryPeriodRepository.Add(model);
                }

                return "1";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        public string ExportProductInventoryPeriods(IEnumerable<ProductInventoryPeriod> productInventoryPeriods)
        {
            try
            {
                foreach (var productInventoryPeriod in productInventoryPeriods)
                {
                    if (productInventoryPeriod == null) break;
                    var model = productInventoryPeriod;

                    var targetExport =
                        _productInventoryPeriodRepository.FindAsNoTracking(
                            f => f.WarehouseId == model.WarehouseId && f.ProductId == model.ProductId).LastOrDefault();

                    model.EarlyPeriodQuantity = targetExport != null ? targetExport.LastPeriodQuantity : 0;
                    model.Quantity = model.Quantity;
                    model.LastPeriodQuantity = model.EarlyPeriodQuantity - model.Quantity;

                    _productInventoryPeriodRepository.Add(model);
                }

                return "1";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string RotateProductInventoryPeriods(IEnumerable<ProductInventoryPeriod> productInventoryPeriodIssues,
            IEnumerable<ProductInventoryPeriod> productInventoryPeriodReceipts)
        {
            try
            {
                // import
                foreach (var productInventoryPeriod in productInventoryPeriodReceipts)
                {
                    if (productInventoryPeriod == null) break;
                    var model = productInventoryPeriod;

                    var targetImport =
                        _productInventoryPeriodRepository.FindAsNoTracking(
                            f => f.WarehouseId == model.WarehouseId && f.ProductId == model.ProductId).LastOrDefault();

                    model.EarlyPeriodQuantity = targetImport != null ? targetImport.LastPeriodQuantity : 0;
                    model.Quantity = model.Quantity;
                    model.LastPeriodQuantity = model.EarlyPeriodQuantity + model.Quantity;

                    _productInventoryPeriodRepository.Add(model);
                }
                // import

                // export
                foreach (var productInventoryPeriod in productInventoryPeriodIssues)
                {
                    if (productInventoryPeriod == null) break;
                    var model = productInventoryPeriod;

                    var targetExport =
                        _productInventoryPeriodRepository.FindAsNoTracking(
                            f => f.WarehouseId == model.WarehouseId && f.ProductId == model.ProductId).LastOrDefault();

                    model.EarlyPeriodQuantity = targetExport != null ? targetExport.LastPeriodQuantity : 0;
                    model.Quantity = model.Quantity;
                    model.LastPeriodQuantity = model.EarlyPeriodQuantity - model.Quantity;

                    _productInventoryPeriodRepository.Add(model);
                }
                // export

                return "1";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }


        #endregion
    }
}
