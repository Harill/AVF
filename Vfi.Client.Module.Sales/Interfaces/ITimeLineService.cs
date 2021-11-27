
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.Sales;

namespace Vfi.Client.Module.Sales.Interfaces
{
    public interface ITimeLineService
    {
        IEnumerable<TimeLine> GetAllTimeLines();
        IEnumerable<TimeLineDomainModel> GetAllTimeLineDomainModels();
        TimeLine GetTimeLineById(int timeLineId);
        IEnumerable<TimeLine> GetTimeLineByWarehouseId(int warehouseId);

        string CreateTimeLine(TimeLine timeLine);
        string UpdateTimeLine(TimeLine timeLine);
    }
}