using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ForecastOrderDetail
    {
        public long DetailId { get; set; }
        public int ForecastOrderId { get; set; }
        public int WarehouseId { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public double ForecastQuantity { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public bool IsWorking { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual ForecastOrder ForecastOrder { get; set; }
    }
}
