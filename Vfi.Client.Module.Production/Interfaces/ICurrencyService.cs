
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.Production;

namespace Vfi.Client.Module.Production.Interfaces
{
    public interface ICurrencyService
    {
        IEnumerable<Currency> GetAllCurrencies();
        IEnumerable<CurrencyDomainModel> GetAllCurrencyDomainModels();
        Currency GetCurrencyByCode(string currencyCode);

        string CreateCurrency(Currency currency);
        string UpdateCurrency(Currency currency);
    }
}
