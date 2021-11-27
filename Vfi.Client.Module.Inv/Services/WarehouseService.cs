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
    public class WarehouseService: IWarehouseService
    {
        private readonly IWarehouseTypeRepository _warehouseTypeRepository;
        private readonly IWarehouseRepository _warehouseRepository;
        [InjectionConstructor]
        public WarehouseService(IWarehouseTypeRepository warehouseTypeRepository,
                                IWarehouseRepository warehouseRepository)
        {
            if (warehouseTypeRepository == null) throw new ArgumentNullException("warehouseTypeRepository");
            if (warehouseRepository == null) throw new ArgumentNullException("warehouseRepository");

            _warehouseTypeRepository = warehouseTypeRepository;
            _warehouseRepository = warehouseRepository;
        }

        #region WarehouseType

        public IEnumerable<WarehouseType> GetAllWarehouseTypes()
        {
            try
            {
                return _warehouseTypeRepository.GetAllAsNoTracking();
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<WarehouseTypeDomainModel> GetAllWarehouseTypeDomainModels()
        {
            try
            {
                return GetAllWarehouseTypes().Select(
                    entity => new WarehouseTypeDomainModel
                                  {
                                      WarehouseTypeId = entity.WarehouseTypeId,
                                      WarehouseTypeName = entity.WarehouseTypeName,

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
        public WarehouseType GetWarehouseTypeById(int warehouseTypeId)
        {
            try
            {
                return
                    _warehouseTypeRepository.FindAsNoTracking(f => f.WarehouseTypeId == warehouseTypeId).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }

        public string CreateWarehouseType(WarehouseType warehouseType)
        {
            try
            {
                var targetCreate = GetWarehouseTypeById(warehouseType.WarehouseTypeId);
                if(targetCreate == null)
                {
                    _warehouseTypeRepository.Add(warehouseType);

                    return "1";
                }
                return "0";
            }
            catch(Exception exception)
            {
                return exception.Message;
            }
        }
        public string UpdateWarehouseType(WarehouseType warehouseType)
        {
            try
            {
                var targetUpdate =
                    _warehouseTypeRepository.Find(f => f.WarehouseTypeId == warehouseType.WarehouseTypeId)
                        .FirstOrDefault();
                if (targetUpdate != null)
                {
                    targetUpdate.WarehouseTypeName = warehouseType.WarehouseTypeName ?? targetUpdate.WarehouseTypeName;
                    targetUpdate.Active = warehouseType.Active;
                    targetUpdate.ModifiedUser = warehouseType.ModifiedUser ?? targetUpdate.ModifiedUser;
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

        #region Warehouse

        public IEnumerable<Warehouse> GetAllWarehouses()
        {
            try
            {
                return _warehouseRepository.GetAllAsNoTracking();
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<WarehouseDomainModel> GetAllWarehouseDomainModels()
        {
            try
            {
                return GetAllWarehouses().Select(
                    entity => new WarehouseDomainModel
                                  {
                                      WarehouseId = entity.WarehouseId,
                                      WarehouseTypeId = entity.WarehouseTypeId,
                                      WarehouseTypeName = entity.WarehouseType != null 
                                                        ? entity.WarehouseType.WarehouseTypeName : "",
                                        
                                      WarehouseName =  entity.WarehouseName,
                                      Description = entity.Description,
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
        public Warehouse GetWarehouseById(int warehouseId)
        {
            try
            {
                return _warehouseRepository.FindAsNoTracking(f => f.WarehouseId == warehouseId).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<Warehouse> GetWarehouseByWarehouseTypeId(int warehouseTypeId)
        {
            try
            {
                return _warehouseRepository.FindAsNoTracking(f => f.WarehouseTypeId == warehouseTypeId);
            }
            catch
            {
                return null;
            }
        }

        public string CreateWarehouse(Warehouse warehouse)
        {
            try
            {
                var targetCreate = GetWarehouseById(warehouse.WarehouseId);
                if(targetCreate == null)
                {
                    _warehouseRepository.Add(warehouse);

                    return "1";
                }
                return "0";
            }
            catch(Exception exception)
            {
                return exception.Message;
            }
        }
        public string UpdateWarehouse(Warehouse warehouse)
        {
            try
            {
                var targetUpdate =
                    _warehouseRepository.Find(f => f.WarehouseId == warehouse.WarehouseId).FirstOrDefault();
                if (targetUpdate != null)
                {
                    targetUpdate.WarehouseTypeId = warehouse.WarehouseTypeId;
                    targetUpdate.WarehouseName = warehouse.WarehouseName ?? targetUpdate.WarehouseName;
                    targetUpdate.Description = warehouse.Description ?? targetUpdate.Description;
                    targetUpdate.Active = warehouse.Active;
                    targetUpdate.ModifiedUser = warehouse.ModifiedUser ?? targetUpdate.ModifiedUser;
                    targetUpdate.ModifiedDate = DateTime.Now;
                    targetUpdate.Idx = warehouse.Idx;
                    return "1";
                }
                return "0";
            }
            catch(Exception exception)
            {
                return exception.Message;
            }
        }
        
        #endregion
    }
}
