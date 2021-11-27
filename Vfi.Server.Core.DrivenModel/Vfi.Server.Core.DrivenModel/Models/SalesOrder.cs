using System;
using System.Collections.Generic;

namespace Vfi.Server.Core.DrivenModel.Models
{
    public partial class SalesOrder
    {
        public SalesOrder()
        {
            WorkOrders = new List<WorkOrder>();
            SalesOrderDetails = new List<SalesOrderDetail>();
        }

        public long SalesOrderId { get; set; }
        public int CustomerId { get; set; }
        public Nullable<int> SalesPersonId { get; set; }
        public System.DateTime OrderDate { get; set; }
        public System.DateTime DueDate { get; set; }
        public Nullable<System.DateTime> ShipDate { get; set; }
        public byte Status { get; set; }
        public string SalesOrderNumber { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public string BillToAddress { get; set; }
        public string ShipToAddress { get; set; }
        public int ShipMethodId { get; set; }
        public string Note { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }
    }
}
