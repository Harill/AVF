
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Client.Module.Production.Interfaces
{
    public interface IUnitMeasureService
    {
        IEnumerable<UnitMeasure> GetAllUnitMeasures();
        UnitMeasure GetUnitMeasureByCode(string unitMeasureCode);

        string CreateUnitMeasure(UnitMeasure unitMeasure);
        string UpdateUnitMeasure(UnitMeasure unitMeasure);
    }
}
