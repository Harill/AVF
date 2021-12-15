using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class OrderProgress
    {
        public int ProgressId { get; set; }
        public int WarehouseId { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public System.DateTime StartDate { get; set; }
        public int ExpectedDay { get; set; }
        public double ExpectedFactor { get; set; }
        public int ProductId { get; set; }
        public long OrderDetailId { get; set; }
        public double NumberProcess { get; set; }
        public double ProductivityInDay { get; set; }
        public int ProcessIndex { get; set; }
        public bool Active { get; set; }
        public string Note { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual OrderDetail OrderDetail { get; set; }
        public virtual Product Product { get; set; }
    }
}
