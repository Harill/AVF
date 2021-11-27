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
    public class MaterialInventoryService: IMaterialInventoryService
    {
        private readonly IMaterialInventoryRepository _materialInventoryRepository;
        [InjectionConstructor]
        public MaterialInventoryService(IMaterialInventoryRepository materialInventoryRepository)
        {
            if (materialInventoryRepository == null) throw new ArgumentNullException("materialInventoryRepository");
            _materialInventoryRepository = materialInventoryRepository;
        }

        #region MaterialInventory

        public IEnumerable<MaterialInventory> GetAllMaterialInventories()
        {
            try
            {
                return _materialInventoryRepository.GetAllAsNoTracking();
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<MaterialInventoryDomainModel> GetAllMaterialInventoryDomainModels()
        {
            try
            {
                return GetAllMaterialInventories().Select(
                    entity => new MaterialInventoryDomainModel
                                  {
                                      MaterialInventoryId = entity.MaterialInventoryId,
                                      
                                      MaterialId = entity.MaterialId,
                                      MaterialCode = entity.Material !=null ? entity.Material.MaterialCode : "",
                                      MaterialName = entity.Material != null ? entity.Material.MaterialName : "",

                                      WarehouseId = entity.WarehouseId,
                                      WarehouseName = entity.Warehouse != null ? entity.Warehouse.WarehouseName : "",

                                      TotalQty = entity.TotalQty??0,
                                      TotalQtyKg = entity.TotalQtyKg ?? 0,
                                      AvailableQty = entity.AvailableQty ?? 0,
                                      UnavailableQty = entity.UnavailableQty ?? 0,

                                      UnitMeasure = entity.UnitMeasure,
                                      Status = entity.Status,

                                      Active = entity.Active,
                                      ModifiedUser = entity.ModifiedUser,
                                      ModifiedDate = entity.ModifiedDate?? DateTime.Now,
                                  });
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<MaterialInventoryDomainModel> ConvertMaterialInventoryToModels(IEnumerable<MaterialInventory> materialInventories)
        {
            try
            {
                return materialInventories.Select(
                    entity => new MaterialInventoryDomainModel
                    {
                        MaterialInventoryId = entity.MaterialInventoryId,

                        MaterialId = entity.MaterialId,
                        MaterialCode = entity.Material != null ? entity.Material.MaterialCode : "",
                        MaterialName = entity.Material != null ? entity.Material.MaterialName : "",

                        WarehouseId = entity.WarehouseId,
                        WarehouseName = entity.Warehouse != null ? entity.Warehouse.WarehouseName : "",

                        TotalQty = entity.TotalQty ?? 0,
                        TotalQtyKg = entity.TotalQtyKg ?? 0,
                        AvailableQty = entity.AvailableQty ?? 0,
                        UnavailableQty = entity.UnavailableQty ?? 0,

                        UnitMeasure = entity.UnitMeasure,
                        Status = entity.Status,

                        Active = entity.Active,
                        ModifiedUser = entity.ModifiedUser,
                        ModifiedDate = entity.ModifiedDate?? DateTime.Now
                    });
            }
            catch
            {
                return null;
            }
        }
        public MaterialInventory GetMaterialInventoryById(long materialInventoryId)
        {
            try
            {
                return
                    _materialInventoryRepository.FindAsNoTracking(f => f.MaterialInventoryId == materialInventoryId)
                    .FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<MaterialInventory> GetMaterialInventoryByMaterialId(int materialId)
        {
            try
            {
                return _materialInventoryRepository.FindAsNoTracking(f => f.MaterialId == materialId);
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<MaterialInventory> GetMaterialInventoryByWarehouseId(int warehouseId)
        {
            try
            {
                return _materialInventoryRepository.FindAsNoTracking(f => f.WarehouseId == warehouseId);
            }
            catch
            {
                return null;
            }
        }
        public MaterialInventory GetMaterialInventory(int? materialId, int? warehouseId)
        {
            try
            {
                return
                    _materialInventoryRepository.FindAsNoTracking(
                        f => f.MaterialId == materialId && f.WarehouseId == warehouseId).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<MaterialInventory> GetMaterialInventoryByStatus(byte status)
        {
            try
            {
                return _materialInventoryRepository.FindAsNoTracking(f => f.Status == status);
            }
            catch
            {
                return null;
            }
        }

        public string CreateMaterialInventory(MaterialInventory materialInventory)
        {
            try
            {
                var targetCreate = GetMaterialInventory(materialInventory.MaterialId, materialInventory.WarehouseId);
                if(targetCreate == null)
                {
                    //_materialInventoryRepository.Add(materialInventory);

                    //return "1";
                }
                return "0";
            }
            catch(Exception exception)
            {
                return exception.Message;
            }
        }
        public string UpdateMaterialInventory(MaterialInventory materialInventory)
        {
            try
            {
                var targetUpdate =
                    _materialInventoryRepository.Find(f => f.MaterialInventoryId == materialInventory.MaterialId)
                    .FirstOrDefault();
                if (targetUpdate != null)
                {
                    //targetUpdate.MaterialId = materialInventory.MaterialId;
                    //targetUpdate.WarehouseId = materialInventory.WarehouseId;
                    //targetUpdate.TotalQty = materialInventory.TotalQty ?? targetUpdate.TotalQty;
                    //targetUpdate.AvailableQty = materialInventory.AvailableQty ?? targetUpdate.AvailableQty;
                    //targetUpdate.TotalQty = materialInventory.UnavailableQty ?? targetUpdate.UnavailableQty;
                    //targetUpdate.UnitMeasure = materialInventory.UnitMeasure ?? targetUpdate.UnitMeasure;
                    //targetUpdate.Status = materialInventory.Status;
                    //targetUpdate.Active = materialInventory.Active;
                    //targetUpdate.ModifiedUser = materialInventory.ModifiedUser ?? targetUpdate.ModifiedUser;
                    //targetUpdate.ModifiedDate = DateTime.Now;

                    //return "1";
                }
                return "0";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string ImportMaterialInventory(MaterialInventory materialInventory)
        {
            try
            {
                var targetImport =
                    _materialInventoryRepository.Find(
                        f =>
                        f.MaterialId == materialInventory.MaterialId && f.WarehouseId == materialInventory.WarehouseId)
                        .FirstOrDefault();

                if (targetImport != null)
                {
                    //targetImport.MaterialId = materialInventory.MaterialId;
                    //targetImport.WarehouseId = materialInventory.WarehouseId;
                    //targetImport.TotalQty = (materialInventory.TotalQty + quantity) ?? targetImport.TotalQty;
                    targetImport.TotalQty = (materialInventory.TotalQty + targetImport.TotalQty);
                    targetImport.TotalQtyKg = (materialInventory.TotalQtyKg + targetImport.TotalQtyKg);
                    //targetImport.AvailableQty = materialInventory.AvailableQty ?? targetImport.AvailableQty;
                    //targetImport.UnavailableQty = materialInventory.UnavailableQty ?? targetImport.UnavailableQty;
                    targetImport.UnitMeasure = materialInventory.UnitMeasure ?? targetImport.UnitMeasure;
                    targetImport.Status = materialInventory.Status;
                    targetImport.Active = materialInventory.Active;
                    targetImport.ModifiedUser = materialInventory.ModifiedUser ?? targetImport.ModifiedUser;
                    targetImport.ModifiedDate = DateTime.Now;

                    return "1";
                }

                _materialInventoryRepository.Add(materialInventory);
                return "1";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        public string ImportMaterialInventories(IEnumerable<MaterialInventory> materialInventories)
        {
            try
            {
                foreach (var materialInventory in materialInventories)
                {
                    var model = materialInventory;
                    var targetImport =
                        _materialInventoryRepository.Find(
                            f =>
                            f.MaterialId == model.MaterialId && f.WarehouseId == model.WarehouseId)
                            .FirstOrDefault();

                    if (targetImport != null)
                    {
                        //targetImport.MaterialId = materialInventory.MaterialId;
                        //targetImport.WarehouseId = materialInventory.WarehouseId;
                        //targetImport.TotalQty = (materialInventory.TotalQty + quantity) ?? targetImport.TotalQty;
                        targetImport.TotalQty = ((materialInventory.TotalQty ?? 0) + (targetImport.TotalQty ??0));
                        targetImport.TotalQtyKg = ((materialInventory.TotalQtyKg ?? 0 )+ (targetImport.TotalQtyKg ?? 0));
                        //targetImport.AvailableQty = materialInventory.AvailableQty ?? targetImport.AvailableQty;
                        //targetImport.UnavailableQty = materialInventory.UnavailableQty ?? targetImport.UnavailableQty;
                        targetImport.UnitMeasure = materialInventory.UnitMeasure ?? targetImport.UnitMeasure;
                        targetImport.Status = materialInventory.Status;
                        targetImport.Active = materialInventory.Active;
                        targetImport.ModifiedUser = materialInventory.ModifiedUser ?? targetImport.ModifiedUser;
                        targetImport.ModifiedDate = DateTime.Now;
                    }
                    else
                        _materialInventoryRepository.Add(materialInventory);
                }

                return "1";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string ExportMaterialInventories(IEnumerable<MaterialInventory> materialInventories)
        {
            try
            {
                foreach (var materialInventory in materialInventories)
                {
                    var model = materialInventory;
                    var targetExport =
                        _materialInventoryRepository.Find(
                            f =>
                            f.MaterialId == model.MaterialId && f.WarehouseId == model.WarehouseId)
                            .FirstOrDefault();

                    if (targetExport != null)
                    {
                        //targetImport.MaterialId = materialInventory.MaterialId;
                        //targetImport.WarehouseId = materialInventory.WarehouseId;
                        //targetImport.TotalQty = (materialInventory.TotalQty + quantity) ?? targetImport.TotalQty;
                        targetExport.TotalQty = ((targetExport.TotalQty ?? 0) - (materialInventory.TotalQty ?? 0));
                        targetExport.TotalQtyKg = ((targetExport.TotalQtyKg ?? 0) - (materialInventory.TotalQtyKg ?? 0));
                        //targetImport.AvailableQty = materialInventory.AvailableQty ?? targetImport.AvailableQty;
                        //targetImport.UnavailableQty = materialInventory.UnavailableQty ?? targetImport.UnavailableQty;
                        targetExport.UnitMeasure = materialInventory.UnitMeasure ?? targetExport.UnitMeasure;
                        targetExport.Status = materialInventory.Status;
                        targetExport.Active = materialInventory.Active;
                        targetExport.ModifiedUser = materialInventory.ModifiedUser ?? targetExport.ModifiedUser;
                        targetExport.ModifiedDate = DateTime.Now;
                    }
                    else
                        _materialInventoryRepository.Add(materialInventory);

                }

                return "1";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string RotateMaterialInventories(IEnumerable<MaterialInventory> materialInventoryIssues
            , IEnumerable<MaterialInventory> materialInventoryReceipts)
        {
            try
            {
                // export
                foreach (var materialInventory in materialInventoryIssues)
                {
                    var model = materialInventory;
                    var targetExport =
                        _materialInventoryRepository.Find(
                            f =>
                            f.MaterialId == model.MaterialId && f.WarehouseId == model.WarehouseId)
                            .FirstOrDefault();

                    if (targetExport == null) continue;

                    //targetImport.MaterialId = materialInventory.MaterialId;
                    //targetImport.WarehouseId = materialInventory.WarehouseId;
                    //targetImport.TotalQty = (materialInventory.TotalQty + quantity) ?? targetImport.TotalQty;
                    targetExport.TotalQty = (targetExport.TotalQty - materialInventory.TotalQty);
                    targetExport.TotalQtyKg = (targetExport.TotalQtyKg - materialInventory.TotalQtyKg);
                    //targetImport.AvailableQty = materialInventory.AvailableQty ?? targetImport.AvailableQty;
                    //targetImport.UnavailableQty = materialInventory.UnavailableQty ?? targetImport.UnavailableQty;
                    targetExport.UnitMeasure = materialInventory.UnitMeasure ?? targetExport.UnitMeasure;
                    targetExport.Status = materialInventory.Status;
                    targetExport.Active = materialInventory.Active;
                    targetExport.ModifiedUser = materialInventory.ModifiedUser ?? targetExport.ModifiedUser;
                    targetExport.ModifiedDate = DateTime.Now;
                    //else
                    //    _materialInventoryRepository.Add(materialInventory);
                }
                // export
                
                // import
                foreach (var materialInventory in materialInventoryReceipts)
                {
                    var model = materialInventory;
                    var targetImport =
                        _materialInventoryRepository.Find(
                            f =>
                            f.MaterialId == model.MaterialId && f.WarehouseId == model.WarehouseId)
                            .FirstOrDefault();

                    if (targetImport != null)
                    {
                        //targetImport.MaterialId = materialInventory.MaterialId;
                        //targetImport.WarehouseId = materialInventory.WarehouseId;
                        //targetImport.TotalQty = (materialInventory.TotalQty + quantity) ?? targetImport.TotalQty;
                        targetImport.TotalQty = (targetImport.TotalQty + materialInventory.TotalQty);
                        targetImport.TotalQtyKg = (targetImport.TotalQtyKg + materialInventory.TotalQtyKg);
                        //targetImport.AvailableQty = materialInventory.AvailableQty ?? targetImport.AvailableQty;
                        //targetImport.UnavailableQty = materialInventory.UnavailableQty ?? targetImport.UnavailableQty;
                        targetImport.UnitMeasure = materialInventory.UnitMeasure ?? targetImport.UnitMeasure;
                        targetImport.Status = materialInventory.Status;
                        targetImport.Active = materialInventory.Active;
                        targetImport.ModifiedUser = materialInventory.ModifiedUser ?? targetImport.ModifiedUser;
                        targetImport.ModifiedDate = DateTime.Now;
                    }
                    else
                        _materialInventoryRepository.Add(materialInventory);
                }
                // import

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
