using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.Unity;
using Vfi.Client.Module.Purchasing.Interfaces;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.Purchasing;
using Vfi.Server.Core.Repository.Purchasing;

namespace Vfi.Client.Module.Purchasing.Services
{
    public class PriceListMaterialService: IPriceListMaterialService
    {
        private readonly IPriceListMaterialRepository _priceListMaterialRepository;
        [InjectionConstructor]
        public PriceListMaterialService(IPriceListMaterialRepository priceListMaterialRepository)
        {
            if (priceListMaterialRepository == null) throw new ArgumentNullException("priceListMaterialRepository");
            _priceListMaterialRepository = priceListMaterialRepository;
        }

        public IEnumerable<PriceListMaterial> GetAllPriceListMaterials()
        {
            try
            {
                return _priceListMaterialRepository.GetAllAsNoTracking();
            }
            catch(Exception)
            {
                return null;
            }
        }
        public IEnumerable<PriceListMaterialDomainModel> GetAllPriceListMaterialModels()
        {
            try
            {
                return GetAllPriceListMaterials().Select(
                    entity => new PriceListMaterialDomainModel
                                  {
                                      PriceListMaterialId = entity.PriceListMaterialId,
                                      MaterialId = entity.MaterialId,
                                      MaterialName = entity.Material != null ? entity.Material.MaterialName : "",

                                      Currency = entity.Currency1 != null ? entity.Currency1.CurrencyCode : "",
                                      CurrencyCode = entity.Currency1 != null ? entity.Currency1.CurrencyCode : "",

                                      NetPrice = entity.NetPrice,
                                      Exchange = entity.Exchange,
                                      Active = entity.Active,
                                      ModifiedUser = entity.ModifiedUser,
                                      ModifiedDate = entity.ModifiedDate
                                  });
            }
            catch(Exception)
            {
                return null;
            }
        }
        public PriceListMaterial GetPriceListMaterialById(long priceListMaterialId)
        {
            try
            {
                return _priceListMaterialRepository.FindAsNoTracking(f => f.PriceListMaterialId == priceListMaterialId)
                    .FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        public PriceListMaterial GetPriceListMaterialByMaterialId(int materialId)
        {
            try
            {
                return _priceListMaterialRepository.FindAsNoTracking(f => f.MaterialId == materialId)
                    .FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }

        public string CreatePriceListMaterial(PriceListMaterial priceListMaterial)
        {
            try
            {
                var targetCreate = GetPriceListMaterialById(priceListMaterial.PriceListMaterialId);
                if(targetCreate == null)
                {
                    _priceListMaterialRepository.Add(priceListMaterial);

                    return "1";
                }
                return "0";
            }
            catch(Exception exception)
            {
                return exception.Message;
            }
        }
        public string UpdatePriceListMaterial(PriceListMaterial priceListMaterial)
        {
            try
            {
                var targetUpdate =
                    _priceListMaterialRepository.Find(
                        f => f.PriceListMaterialId == priceListMaterial.PriceListMaterialId).FirstOrDefault();
                if (targetUpdate != null)
                {
                    targetUpdate.MaterialId = priceListMaterial.MaterialId;

                    targetUpdate.Currency = priceListMaterial.Currency;
                    targetUpdate.NetPrice = priceListMaterial.NetPrice;
                    targetUpdate.Exchange = priceListMaterial.Exchange;

                    targetUpdate.Active = priceListMaterial.Active;
                    targetUpdate.ModifiedUser = priceListMaterial.ModifiedUser;
                    targetUpdate.ModifiedDate = priceListMaterial.ModifiedDate;

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
