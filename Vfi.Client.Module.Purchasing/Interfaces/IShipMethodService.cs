
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.Purchasing;

namespace Vfi.Client.Module.Purchasing.Interfaces
{
    public interface IShipMethodService
    {
        IEnumerable<ShipMethod> GetAllShipMethods();
        IEnumerable<ShipMethodDomainModel> GetAllShipMethodDomainModel();
        ShipMethod GetShipMethodById(int shipMethodId);

        string CreateShipMethod(ShipMethod shipMethod);
        string UpdateShipMethod(ShipMethod shipMethod);
    }
}
