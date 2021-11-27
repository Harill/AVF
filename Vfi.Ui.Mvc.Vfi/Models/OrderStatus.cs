using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class OrderStatus
    {
        public int OrderStatusId { get; set; }
        public Nullable<long> OrderDetailId { get; set; }
        public Nullable<double> Qty { get; set; }
        public byte Status { get; set; }
        public virtual OrderDetail OrderDetail { get; set; }
    }
}
