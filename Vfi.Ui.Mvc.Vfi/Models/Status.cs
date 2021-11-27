using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class Status
    {
        public Status()
        {
            this.OrderDetails = new List<OrderDetail>();
        }

        public int StatusId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
