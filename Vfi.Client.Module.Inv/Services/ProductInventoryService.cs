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
    public class ProductInventoryService: IProductInventoryService
    {
        private readonly IProductInventoryRepository _productInventoryRepository;
        [InjectionConstructor]
        public ProductInventoryService(IProductInventoryRepository productInventoryRepository)
        {
            if (productInventoryRepository == null) throw new ArgumentNullException("productInventoryRepository");
            _productInventoryRepository = productInventoryRepository;
        }

        #region ProductInventory

        public IEnumerable<ProductInventory> GetAllProductInventories()
        {
            try
            {
                return _productInventoryRepository.GetAllAsNoTracking();
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<ProductInventoryDomainModel> GetAllProductInventoryDomainModels()
        {
            try
            {
                return GetAllProductInventories().Select(
                    entity => new ProductInventoryDomainModel
                                  {
                                      ProductInventoryId = entity.ProductInventoryId,
                                      
                                      ProductId = entity.ProductId,
                                      ProductCode = entity.Product !=null ? entity.Product.ProductCode : "",
                                      ProductName = entity.Product != null ? entity.Product.ProductName : "",

                                      WarehouseId = entity.WarehouseId,
                                      WarehouseName = entity.Warehouse != null ? entity.Warehouse.WarehouseName : "",

                                      TotalQty = entity.TotalQty??0,
                                      AvailableQty = entity.AvailableQty??0,
                                      UnavailableQty = entity.UnavailableQty??0,
                                      
                                      UnitMeasure = entity.UnitMeasure,
                                      Status = entity.Status,

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
        public ProductInventory GetProductInventoryById(long productInventoryId)
        {
            try
            {
                return
                    _productInventoryRepository.FindAsNoTracking(f => f.ProductInventoryId == productInventoryId)
                    .FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<ProductInventory> GetProductInventoryByProductId(int productId)
        {
            try
            {
                return _productInventoryRepository.FindAsNoTracking(f => f.ProductId == productId);
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<ProductInventory> GetProductInventoryByWarehouseId(int warehouseId)
        {
            try
            {
                return _productInventoryRepository.FindAsNoTracking(f => f.WarehouseId == warehouseId);
            }
            catch
            {
                return null;
            }
        }
        public ProductInventory GetProductInventory(int? productId, int? warehouseId)
        {
            try
            {
                return
                    _productInventoryRepository.FindAsNoTracking(
                        f => f.ProductId == productId && f.WarehouseId == warehouseId).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<ProductInventory> GetProductInventoryByStatus(byte status)
        {
            try
            {
                return _productInventoryRepository.FindAsNoTracking(f => f.Status == status);
            }
            catch
            {
                return null;
            }
        }

        public IEnumerable<ProductInventoryDomainModel> ConvertProductInventoryToModels(
            IEnumerable<ProductInventory> productInventories)
        {
            try
            {
                return productInventories.Select(
                    entity => new ProductInventoryDomainModel
                    {
                        
                        ProductInventoryId = entity.ProductInventoryId,

                        ProductId = entity.ProductId,
                        ProductCode = entity.Product != null ? entity.Product.ProductCode : "",
                        ProductName = entity.Product != null ? entity.Product.ProductName : "",

                        CustomerCode = (entity.Product != null && entity.Product.Customer != null) ? entity.Product.Customer.CustomerCode : "",

                        WarehouseId = entity.WarehouseId,
                        WarehouseName = entity.Warehouse != null ? entity.Warehouse.WarehouseName : "",

                        TotalQty = entity.TotalQty??0,
                        AvailableQty = entity.AvailableQty??0,
                        UnavailableQty = entity.UnavailableQty??0,

                        UnitMeasure = entity.UnitMeasure,
                        Status = entity.Status,

                        Active = entity.Active,
                        ModifiedUser = entity.ModifiedUser,
                        ModifiedDate = entity.ModifiedDate,
                        
                    });
            }
            catch
            {
                return null;
            }
        } 

        public string CreateProductInventory(ProductInventory productInventory)
        {
            try
            {
                var targetCreate = GetProductInventory(productInventory.ProductId, productInventory.WarehouseId);
                if(targetCreate == null)
                {
                    _productInventoryRepository.Add(productInventory);

                    return "1";
                }
                return "0";
            }
            catch(Exception exception)
            {
                return exception.Message;
            }
        }
        public string UpdateProductInventory(ProductInventory productInventory)
        {
            try
            {
                var targetUpdate =
                    _productInventoryRepository.Find(f => f.ProductInventoryId == productInventory.ProductId)
                    .FirstOrDefault();
                if (targetUpdate != null)
                {
                    targetUpdate.ProductId = productInventory.ProductId;
                    targetUpdate.WarehouseId = productInventory.WarehouseId;
                    targetUpdate.TotalQty = productInventory.TotalQty ?? targetUpdate.TotalQty;
                    if (targetUpdate.TotalQty == null) targetUpdate.TotalQty = 0;
                    targetUpdate.AvailableQty = productInventory.AvailableQty ?? targetUpdate.AvailableQty;
                    targetUpdate.UnavailableQty = productInventory.UnavailableQty ?? targetUpdate.UnavailableQty;
                    targetUpdate.UnitMeasure = productInventory.UnitMeasure ?? targetUpdate.UnitMeasure;
                    targetUpdate.Status = productInventory.Status;
                    targetUpdate.Active = productInventory.Active;
                    targetUpdate.ModifiedUser = productInventory.ModifiedUser ?? targetUpdate.ModifiedUser;
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

        public string ImportProductInventory(ProductInventory productInventory)
        {
            try
            {
                var targetImport =
                    _productInventoryRepository.Find(
                        f =>
                        f.ProductId == productInventory.ProductId && f.WarehouseId == productInventory.WarehouseId)
                        .FirstOrDefault();

                if (targetImport != null)
                {
                    //targetImport.MaterialId = materialInventory.MaterialId;
                    //targetImport.WarehouseId = materialInventory.WarehouseId;
                    //targetImport.TotalQty = (materialInventory.TotalQty + quantity) ?? targetImport.TotalQty;
                    targetImport.TotalQty = (productInventory.TotalQty + (targetImport.TotalQty ?? 0));
                    if (targetImport.TotalQty == null) targetImport.TotalQty = productInventory.TotalQty;
                    //targetImport.AvailableQty = materialInventory.AvailableQty ?? targetImport.AvailableQty;
                    //targetImport.UnavailableQty = materialInventory.UnavailableQty ?? targetImport.UnavailableQty;
                    targetImport.UnitMeasure = productInventory.UnitMeasure ?? targetImport.UnitMeasure;
                    targetImport.Status = productInventory.Status;
                    targetImport.Active = productInventory.Active;
                    targetImport.ModifiedUser = productInventory.ModifiedUser ?? targetImport.ModifiedUser;
                    targetImport.ModifiedDate = DateTime.Now;

                    return "1";
                }

                _productInventoryRepository.Add(productInventory);
                return "1";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        public string ImportProductInventories(IEnumerable<ProductInventory> productInventories)
        {
            try
            {
                foreach (var productInventory in productInventories)
                {
                    var model = productInventory;
                    var targetImport =
                        _productInventoryRepository.Find(
                            f =>
                            f.ProductId == model.ProductId && f.WarehouseId == model.WarehouseId)
                            .FirstOrDefault();

                    if (targetImport != null)
                    {
                        //targetImport.MaterialId = materialInventory.MaterialId;
                        //targetImport.WarehouseId = materialInventory.WarehouseId;
                        //targetImport.TotalQty = (materialInventory.TotalQty + quantity) ?? targetImport.TotalQty;
                        targetImport.TotalQty = (productInventory.TotalQty + (targetImport.TotalQty ?? 0));
                        if (targetImport.TotalQty == null) targetImport.TotalQty = productInventory.TotalQty;
                        //targetImport.AvailableQty = materialInventory.AvailableQty ?? targetImport.AvailableQty;
                        //targetImport.UnavailableQty = materialInventory.UnavailableQty ?? targetImport.UnavailableQty;
                        targetImport.UnitMeasure = productInventory.UnitMeasure ?? targetImport.UnitMeasure;
                        targetImport.Status = productInventory.Status;
                        targetImport.Active = productInventory.Active;
                        targetImport.ModifiedUser = productInventory.ModifiedUser ?? targetImport.ModifiedUser;
                        targetImport.ModifiedDate = DateTime.Now;
                    }
                    else
                        _productInventoryRepository.Add(productInventory);
                }

                return "1";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string ExportProductInventories(IEnumerable<ProductInventory> productInventories)
        {
            try
            {
                foreach (var productInventory in productInventories)
                {
                    var model = productInventory;
                    var targetExport =
                        _productInventoryRepository.Find(
                            f =>
                            f.ProductId == model.ProductId && f.WarehouseId == model.WarehouseId)
                            .FirstOrDefault();

                    if (targetExport != null)
                    {
                        //targetImport.MaterialId = materialInventory.MaterialId;
                        //targetImport.WarehouseId = materialInventory.WarehouseId;
                        //targetImport.TotalQty = (materialInventory.TotalQty + quantity) ?? targetImport.TotalQty;
                        targetExport.TotalQty = ((targetExport.TotalQty ?? 0) - productInventory.TotalQty);
                        if (targetExport.TotalQty == null) targetExport.TotalQty = productInventory.TotalQty;
                        //targetImport.AvailableQty = materialInventory.AvailableQty ?? targetImport.AvailableQty;
                        //targetImport.UnavailableQty = materialInventory.UnavailableQty ?? targetImport.UnavailableQty;
                        targetExport.UnitMeasure = productInventory.UnitMeasure ?? targetExport.UnitMeasure;
                        targetExport.Status = productInventory.Status;
                        targetExport.Active = productInventory.Active;
                        targetExport.ModifiedUser = productInventory.ModifiedUser ?? targetExport.ModifiedUser;
                        targetExport.ModifiedDate = DateTime.Now;
                    }
                    else
                        _productInventoryRepository.Add(productInventory);
                }

                return "1";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string RotateProductInventories(IEnumerable<ProductInventory> productInventoryIssues
            , IEnumerable<ProductInventory> productInventoryReceipts)
        {
            try
            {
                // export
                foreach (var productInventory in productInventoryIssues)
                {
                    var model = productInventory;
                    var targetExport =
                        _productInventoryRepository.Find(
                            f =>
                            f.ProductId == model.ProductId && f.WarehouseId == model.WarehouseId)
                            .FirstOrDefault();

                    if (targetExport == null) continue;
                    // if issue qty less than receive
                    if (targetExport.TotalQty < model.TotalQty)
                    {
                        throw new ArgumentException("Not Enough Quantity !");
                    }
                    
                    //targetImport.MaterialId = materialInventory.MaterialId;
                    //targetImport.WarehouseId = materialInventory.WarehouseId;
                    //targetImport.TotalQty = (materialInventory.TotalQty + quantity) ?? targetImport.TotalQty;
                    targetExport.TotalQty = ((targetExport.TotalQty ?? 0) - productInventory.TotalQty);
                    if (targetExport.TotalQty == null) targetExport.TotalQty = productInventory.TotalQty;
                    //targetImport.AvailableQty = materialInventory.AvailableQty ?? targetImport.AvailableQty;
                    //targetImport.UnavailableQty = materialInventory.UnavailableQty ?? targetImport.UnavailableQty;
                    targetExport.UnitMeasure = productInventory.UnitMeasure ?? targetExport.UnitMeasure;
                    targetExport.Status = productInventory.Status;
                    targetExport.Active = productInventory.Active;
                    targetExport.ModifiedUser = productInventory.ModifiedUser ?? targetExport.ModifiedUser;
                    targetExport.ModifiedDate = DateTime.Now;
                    //else
                    //    _materialInventoryRepository.Add(materialInventory);
                }
                // export

                // import
                foreach (var productInventory in productInventoryReceipts)
                {
                    var model = productInventory;
                    var targetImport =
                        _productInventoryRepository.Find(
                            f =>
                            f.ProductId == model.ProductId && f.WarehouseId == model.WarehouseId)
                            .FirstOrDefault();

                    if (targetImport != null)
                    {
                        //targetImport.MaterialId = materialInventory.MaterialId;
                        //targetImport.WarehouseId = materialInventory.WarehouseId;
                        //targetImport.TotalQty = (materialInventory.TotalQty + quantity) ?? targetImport.TotalQty;
                        targetImport.TotalQty = (productInventory.TotalQty + (targetImport.TotalQty ?? 0));
                        if (targetImport.TotalQty == null) targetImport.TotalQty = productInventory.TotalQty;
                        //targetImport.AvailableQty = materialInventory.AvailableQty ?? targetImport.AvailableQty;
                        //targetImport.UnavailableQty = materialInventory.UnavailableQty ?? targetImport.UnavailableQty;
                        targetImport.UnitMeasure = productInventory.UnitMeasure ?? targetImport.UnitMeasure;
                        targetImport.Status = productInventory.Status;
                        targetImport.Active = productInventory.Active;
                        targetImport.ModifiedUser = productInventory.ModifiedUser ?? targetImport.ModifiedUser;
                        targetImport.ModifiedDate = DateTime.Now;
                    }
                    else
                        _productInventoryRepository.Add(productInventory);
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
