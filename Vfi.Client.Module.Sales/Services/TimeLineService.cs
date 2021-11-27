using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.Unity;
using Vfi.Client.Module.Sales.Interfaces;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.Sales;
using Vfi.Server.Core.Repository.Sales;

namespace Vfi.Client.Module.Sales.Services
{
    public class TimeLineService: ITimeLineService
    {
        private readonly ITimeLineRepository _timeLineRepository;
        [InjectionConstructor]
        public TimeLineService(ITimeLineRepository timeLineRepository)
        {
            if (timeLineRepository == null) throw new ArgumentNullException("timeLineRepository");
            _timeLineRepository = timeLineRepository;
        }

        #region Timeline

        public IEnumerable<TimeLine> GetAllTimeLines()
        {
            try
            {
                return _timeLineRepository.GetAllAsNoTracking();
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<TimeLineDomainModel> GetAllTimeLineDomainModels()
        {
            try
            {
                return GetAllTimeLines().Select(
                    entity => new TimeLineDomainModel
                                  {
                                      TimeLineId = entity.TimeLineId,
                                      WarehouseId = entity.WarehouseId,
                                      WarehouseName = entity.Warehouse != null ? entity.Warehouse.WarehouseName : "",
                                      SalesOrderDetailId = entity.OrderDetailId,

                                      Times = entity.Times,
                                      RealTimes = entity.RealTimes,
                                      Performance = entity.Performance,
                                      StartDay = entity.StartDay,
                                      FinishedDay = entity.FinishedDay,
                                      WorkingHours = entity.WorkingHours,

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
        public TimeLine GetTimeLineById(int timeLineId)
        {
            try
            {
                return _timeLineRepository.FindAsNoTracking(f => f.TimeLineId == timeLineId).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<TimeLine> GetTimeLineByWarehouseId(int warehouseId)
        {
            try
            {
                return _timeLineRepository.FindAsNoTracking(f => f.WarehouseId == warehouseId);
            }
            catch
            {
                return null;
            }
        }

        public string CreateTimeLine(TimeLine timeLine)
        {
            try
            {
                var targetCreate = GetTimeLineById(timeLine.TimeLineId);
                if(targetCreate == null)
                {
                    _timeLineRepository.Add(timeLine);

                    return "1";
                }
                return "0";
            }
            catch(Exception exception)
            {
                return exception.Message;
            }
        }
        public string UpdateTimeLine(TimeLine timeLine)
        {
            try
            {
                var targetUpdate = _timeLineRepository.Find(f => f.TimeLineId == timeLine.TimeLineId).FirstOrDefault();
                if (targetUpdate != null)
                {
                    targetUpdate.WarehouseId = timeLine.WarehouseId ?? targetUpdate.WarehouseId;
                    targetUpdate.Times = timeLine.Times ?? targetUpdate.Times;
                    targetUpdate.RealTimes = timeLine.RealTimes ?? targetUpdate.RealTimes;
                    targetUpdate.Performance = timeLine.Performance ?? targetUpdate.Performance;
                    targetUpdate.StartDay = timeLine.StartDay ?? targetUpdate.StartDay;
                    targetUpdate.FinishedDay = timeLine.FinishedDay ?? targetUpdate.FinishedDay;
                    targetUpdate.WorkingHours = timeLine.WorkingHours ?? targetUpdate.WorkingHours;

                    targetUpdate.Active = timeLine.Active;
                    targetUpdate.ModifiedUser = timeLine.ModifiedUser ?? targetUpdate.ModifiedUser;
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
    }
}
