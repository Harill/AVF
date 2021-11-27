using System;
using System.Collections.Generic;

namespace Vfi.Server.Core.DrivenModel.Models
{
    public partial class SalesOrderDetail
    {
        public SalesOrderDetail()
        {
            TimeLines = new List<TimeLine>();
        }

        public long SalesOrderDetailId { get; set; }
        public long SalesOrderId { get; set; }
        public int ProductId { get; set; }
        public string PoNoOfCustomer { get; set; }
        public string LotNoOfCustomer { get; set; }
        public string ModelNoOfCustomer { get; set; }
        public string CarrierTrackingNumber { get; set; }
        public short OrderQty { get; set; }
        public double UnitPrice { get; set; }
        public double UnitPriceDiscount { get; set; }
        public double LineTotal { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual Product Product { get; set; }
        public virtual SalesOrder SalesOrder { get; set; }
        public virtual ICollection<TimeLine> TimeLines { get; set; }
    }
}
