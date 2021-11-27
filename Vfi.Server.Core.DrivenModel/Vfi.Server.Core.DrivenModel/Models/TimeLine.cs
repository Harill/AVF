using System;
using System.Collections.Generic;

namespace Vfi.Server.Core.DrivenModel.Models
{
    public partial class TimeLine
    {
        public int TimeLineId { get; set; }
        public Nullable<int> WarehouseId { get; set; }
        public Nullable<long> SalesOrderDetailId { get; set; }
        public Nullable<int> Times { get; set; }
        public Nullable<int> RealTimes { get; set; }
        public Nullable<double> Performance { get; set; }
        public Nullable<System.DateTime> StartDay { get; set; }
        public Nullable<System.DateTime> FinishedDay { get; set; }
        public Nullable<int> WorkingHours { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual SalesOrderDetail SalesOrderDetail { get; set; }
    }
}
