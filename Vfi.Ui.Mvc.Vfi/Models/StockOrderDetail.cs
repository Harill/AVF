using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class StockOrderDetail
    {
        public long StockOrderDetailId { get; set; }
        public long StockOrderId { get; set; }
        public Nullable<int> ReferenceId { get; set; }
        public bool MoP { get; set; }
        public Nullable<double> Quantity { get; set; }
        public string UnitMeasure { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual Material Material { get; set; }
        public virtual Product Product { get; set; }
    }
}
