using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using Vfi.Client.Module.Purchasing.Interfaces;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.Purchasing;
using Vfi.Server.Core.Repository.Purchasing;

namespace Vfi.Client.Module.Purchasing.Services
{
    public class ShipMethodService: IShipMethodService
    {
        private readonly IShipMethodRepository _shipMethodRepository;
        [InjectionConstructor]
        public ShipMethodService(IShipMethodRepository shipMethodRepository)
        {
            if (shipMethodRepository == null) throw new ArgumentNullException("shipMethodRepository");
            _shipMethodRepository = shipMethodRepository;
        }

        public IEnumerable<ShipMethod> GetAllShipMethods()
        {
            try
            {
                return _shipMethodRepository.GetAllAsNoTracking();
            }
            catch(Exception)
            {
                return null;
            }
        }

        public IEnumerable<ShipMethodDomainModel> GetAllShipMethodDomainModel()
        {
            try
            {
                return GetAllShipMethods().Select(
                    entity => new ShipMethodDomainModel
                                  {
                                      ShipMethodId = entity.ShipMethodId,
                                      Name = entity.Name,
                                      ShipBase = entity.ShipBase,
                                      ShipRate = entity.ShipRate,
                                      Active = entity.Active,
                                      ModifiedUser = entity.ModifiedUser,
                                      ModifiedDate = entity.ModifiedDate
                                  });
            }
            catch (Exception)
            {
                return null;
            }
        }
        public ShipMethod GetShipMethodById(int shipMethodId)
        {
            try
            {
                return _shipMethodRepository.FindAsNoTracking(f=>f.ShipMethodId == shipMethodId).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }   
        }

        public string CreateShipMethod(ShipMethod shipMethod)
        {
            try
            {
                var targetCreate =
                    _shipMethodRepository.FindAsNoTracking(f => f.ShipMethodId == shipMethod.ShipMethodId)
                    .FirstOrDefault();
                if(targetCreate == null)
                {
                    _shipMethodRepository.Add(shipMethod);
                    return "1";
                }
                return "0";
            }
            catch(Exception exception)
            {
                return exception.Message;
            }
        }
        public string UpdateShipMethod(ShipMethod shipMethod)
        {
            try
            {
                var targetUpdate =
                    _shipMethodRepository.Find(f => f.ShipMethodId == shipMethod.ShipMethodId)
                    .FirstOrDefault();
                if (targetUpdate != null)
                {
                    targetUpdate.Name = shipMethod.Name ?? targetUpdate.Name;
                    targetUpdate.ShipBase = shipMethod.ShipBase ?? targetUpdate.ShipBase;
                    targetUpdate.ShipRate = shipMethod.ShipRate ?? targetUpdate.ShipRate;
                    targetUpdate.Active = shipMethod.Active;
                    targetUpdate.ModifiedUser = shipMethod.ModifiedUser ?? targetUpdate.ModifiedUser;
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
    }
}
