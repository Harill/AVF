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
    public class MaterialInventoryPeriodService : IMaterialInventoryPeriodService
    {
        private readonly IMaterialInventoryPeriodRepository _materialInventoryPeriodRepository;
        [InjectionConstructor]
        public MaterialInventoryPeriodService(IMaterialInventoryPeriodRepository materialInventoryPeriodRepository)
        {
            if (materialInventoryPeriodRepository == null)
                throw new ArgumentNullException("materialInventoryPeriodRepository");
            _materialInventoryPeriodRepository = materialInventoryPeriodRepository;
        }

        #region MaterialInventoryPeriod
        public IEnumerable<MaterialInventoryPeriod> GetAllMaterialInventoryPeriods()
        {
            try
            {
                return _materialInventoryPeriodRepository.GetAllAsNoTracking();
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<MaterialInventoryPeriodDomainModel> GetAllMaterialInventoryPeroidDomainModels()
        {
            try
            {
                return GetAllMaterialInventoryPeriods().Select(
                    entity => new MaterialInventoryPeriodDomainModel
                                  {
                                      MaterialInventoryPeriodId = entity.MaterialInventoryPeriodId,
                                      
                                      TransactionId = entity.TransactionId,
                                      
                                      MaterialId = entity.MaterialId,
                                      MaterialCode = entity.Material != null ? entity.Material.MaterialCode : "",
                                      MaterialName = entity.Material != null ? entity.Material.MaterialName : "",

                                      WarehouseId = entity.WarehouseId,
                                      WarehouseName = entity.Warehouse != null ? entity.Warehouse.WarehouseName : "",

                                      PeriodDay = entity.PeriodDay,
                                      PeriodMonth = entity.PeriodMonth,
                                      PeriodYear = entity.PeriodYear,
                                      PeriodDate = entity.PeriodDate,

                                      EarlyPeriodQuantity = entity.EarlyPeriodQuantity,
                                      EarlyPeriodQuantityKg = entity.EarlyPeriodQuantityKg,
                                      EarlyPeriodPrice = entity.EarlyPeriodPrice,

                                      Quantity = entity.Quantity,
                                      QuantityKg = entity.QuantityKg,
                                      UnitPrice = entity.UnitPrice,
                                      Price = entity.Price,
                                      UnitMeasure = entity.UnitMeasure,

                                      LastPeriodQuantity = entity.LastPeriodQuantity,
                                      LastPeriodQuantityKg = entity.LastPeriodQuantityKg,
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
        public IEnumerable<MaterialInventoryPeriod> GetMaterialInventoryPeriodByTransactionId(long transactionId)
        {
            try
            {
                return _materialInventoryPeriodRepository.FindAsNoTracking(f => f.TransactionId == transactionId);
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<MaterialInventoryPeriod> GetMaterialInventoryPeriodByMaterialId(int materialId)
        {
            try
            {
                return _materialInventoryPeriodRepository.FindAsNoTracking(f => f.MaterialId == materialId);
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<MaterialInventoryPeriod> GetMaterialInventoryPeriodByWarehouseId(int warehouseId)
        {
            try
            {
                return _materialInventoryPeriodRepository.FindAsNoTracking(f => f.WarehouseId == warehouseId);
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<MaterialInventoryPeriod> GetMaterialInventoryPeriods(int materialId, int warehouseId)
        {
            try
            {
                return
                    _materialInventoryPeriodRepository.FindAsNoTracking(
                        f => f.MaterialId == materialId && f.WarehouseId == warehouseId);
            }
            catch
            {
                return null;
            }
        }

        public string CreateMaterialInventoryPeriod(MaterialInventoryPeriod materialInventoryPeriod)
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
        public string UpdateMaterialInventoryPeriod(MaterialInventoryPeriod materialInventoryPeriod)
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

        public string ImportMaterialInventoryPeriods(IEnumerable<MaterialInventoryPeriod> materialInventoryPeriods)
        {
            try
            {
                foreach (var materialInventoryPeriod in materialInventoryPeriods)
                {
                    if (materialInventoryPeriod == null) break;
                    var model = materialInventoryPeriod;
                    
                    var targetImport =
                        _materialInventoryPeriodRepository.FindAsNoTracking(
                            f => f.WarehouseId == model.WarehouseId && f.MaterialId == model.MaterialId).LastOrDefault();

                    model.EarlyPeriodQuantity = targetImport != null ? (targetImport.LastPeriodQuantity ?? 0) : 0;
                    model.EarlyPeriodQuantityKg = targetImport != null ? (targetImport.LastPeriodQuantityKg ?? 0) : 0;
                    
                    model.Quantity = model.Quantity;
                    model.QuantityKg = model.QuantityKg;

                    model.LastPeriodQuantity = (model.EarlyPeriodQuantity) + (model.Quantity ?? 0);
                    model.LastPeriodQuantityKg = (model.EarlyPeriodQuantityKg) + (model.QuantityKg ?? 0);

                    //model.Price = model.Price;

                    _materialInventoryPeriodRepository.Add(model);
                }

                return "1";
            }
            catch(Exception exception)
            {
                return exception.Message;
            }
        }
        public string ExportMaterialInventoryPeriods(IEnumerable<MaterialInventoryPeriod> materialInventoryPeriods)
        {
            try
            {
                foreach (var materialInventoryPeriod in materialInventoryPeriods)
                {
                    if (materialInventoryPeriod == null) break;
                    var model = materialInventoryPeriod;
                    
                    var targetExport =
                        _materialInventoryPeriodRepository.FindAsNoTracking(
                            f => f.WarehouseId == model.WarehouseId && f.MaterialId == model.MaterialId).LastOrDefault();

                    model.EarlyPeriodQuantity = targetExport != null ? (targetExport.LastPeriodQuantity ?? 0) : 0;
                    model.EarlyPeriodQuantityKg = targetExport != null ? (targetExport.LastPeriodQuantityKg ?? 0) : 0;

                    model.Quantity = model.Quantity;
                    model.QuantityKg = model.QuantityKg;

                    model.LastPeriodQuantity = (model.EarlyPeriodQuantity) - (model.Quantity ?? 0 );
                    model.LastPeriodQuantityKg = (model.EarlyPeriodQuantityKg) - (model.QuantityKg ?? 0 );

                    //model.Price = model.Price;

                    _materialInventoryPeriodRepository.Add(model);
                }

                return "1";
            }
            catch(Exception exception)
            {
                return exception.Message;
            }
        }

        public string RotateMaterialInventoryPeriods(IEnumerable<MaterialInventoryPeriod> materialInventoryPeriodIssues,
            IEnumerable<MaterialInventoryPeriod> materialInventoryPeriodReceipts)
        {
            try
            {
                // import
                foreach (var materialInventoryPeriod in materialInventoryPeriodReceipts)
                {
                    if (materialInventoryPeriod == null) break;
                    var model = materialInventoryPeriod;

                    var targetImport =
                        _materialInventoryPeriodRepository.FindAsNoTracking(
                            f => f.WarehouseId == model.WarehouseId && f.MaterialId == model.MaterialId).LastOrDefault();

                    model.EarlyPeriodQuantity = targetImport != null ? (targetImport.LastPeriodQuantity ?? 0) : 0;
                    model.EarlyPeriodQuantityKg = targetImport != null ? (targetImport.LastPeriodQuantityKg ?? 0) : 0;

                    model.Quantity = model.Quantity;
                    model.QuantityKg = model.QuantityKg;

                    model.LastPeriodQuantity = model.EarlyPeriodQuantity + (model.Quantity ?? 0);
                    model.LastPeriodQuantityKg = model.EarlyPeriodQuantityKg + (model.QuantityKg ?? 0);

                    _materialInventoryPeriodRepository.Add(model);
                }
                // import

                // export
                foreach (var materialInventoryPeriod in materialInventoryPeriodIssues)
                {
                    if (materialInventoryPeriod == null) break;
                    var model = materialInventoryPeriod;

                    var targetExport =
                        _materialInventoryPeriodRepository.FindAsNoTracking(
                            f => f.WarehouseId == model.WarehouseId && f.MaterialId == model.MaterialId).LastOrDefault();

                    model.EarlyPeriodQuantity = targetExport != null ? (targetExport.LastPeriodQuantity ?? 0) : 0;
                    model.EarlyPeriodQuantityKg = targetExport != null ? (targetExport.LastPeriodQuantityKg ?? 0) : 0;
                    

                   
                    model.Quantity = model.Quantity;
                    model.QuantityKg = model.QuantityKg;

                    
                    model.LastPeriodQuantity = model.EarlyPeriodQuantity - (model.Quantity ?? 0 );
                    model.LastPeriodQuantityKg = model.EarlyPeriodQuantityKg - (model.QuantityKg ?? 0);

                    _materialInventoryPeriodRepository.Add(model);
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
