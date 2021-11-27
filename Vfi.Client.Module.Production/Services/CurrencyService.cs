using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.Unity;
using Vfi.Client.Module.Production.Interfaces;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.Production;
using Vfi.Server.Core.Repository.Production;

namespace Vfi.Client.Module.Production.Services
{
    public class CurrencyService: ICurrencyService
    {
        private readonly ICurrencyRepository _currencyRepository;
        [InjectionConstructor]
        public CurrencyService(ICurrencyRepository currencyRepository)
        {
            if (currencyRepository == null) throw new ArgumentNullException("currencyRepository");

            _currencyRepository = currencyRepository;
        }

        public IEnumerable<Currency> GetAllCurrencies()
        {
            try
            {
                return _currencyRepository.GetAllAsNoTracking();
            }
            catch(Exception)
            {
                return null;
            }
        }
        public IEnumerable<CurrencyDomainModel> GetAllCurrencyDomainModels()
        {
            try
            {
                return GetAllCurrencies().Select(
                    entity => new CurrencyDomainModel
                    {
                        CurrencyCode = entity.CurrencyCode,
                        CurrencyName = entity.CurrencyName,
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
        public Currency GetCurrencyByCode(string currencyCode)
        {
            try
            {
                return
                    _currencyRepository.FindAsNoTracking(
                        f => f.CurrencyCode.Equals(currencyCode, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
            }
            catch(Exception)
            {
                return null;
            }
        }

        public string CreateCurrency(Currency currency)
        {
            try
            {
                var targetCreate =
                    _currencyRepository.Find(
                        f => f.CurrencyCode.Equals(currency.CurrencyCode, StringComparison.OrdinalIgnoreCase))
                        .FirstOrDefault();
                if(targetCreate == null)
                {
                    _currencyRepository.Add(currency);
                    return "1";
                }
                return "0";
            }
            catch(Exception exception)
            {
                return exception.Message;
            }
        }
        public string UpdateCurrency(Currency currency)
        {
            try
            {
                var targetUpdate =
                    _currencyRepository.Find(
                        f => f.CurrencyCode.Equals(currency.CurrencyCode, StringComparison.OrdinalIgnoreCase))
                        .FirstOrDefault();
                if (targetUpdate != null)
                {
                    targetUpdate.CurrencyName = currency.CurrencyName ?? targetUpdate.CurrencyName;
                    targetUpdate.Active = currency.Active;
                    targetUpdate.ModifiedUser = currency.ModifiedUser ?? targetUpdate.ModifiedUser;
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
