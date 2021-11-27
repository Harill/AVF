using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class MaterialLimitPlan
    {
        public int LimitId { get; set; }
        public int MaterialId { get; set; }
        public int ProductId { get; set; }
        public double MaterialLimitQuantity { get; set; }
        public double ProductLimitQuantity { get; set; }
        public double Productivity { get; set; }
        public System.DateTime ApplyDate { get; set; }
        public bool IsLock { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public double RawProductionWeight { get; set; }
        public int EstimateLossPercent { get; set; }
        public int WorkpieceLossPercent { get; set; }
        public int ExpiredDay { get; set; }
        public virtual Material Material { get; set; }
        public virtual Product Product { get; set; }
    }
}
