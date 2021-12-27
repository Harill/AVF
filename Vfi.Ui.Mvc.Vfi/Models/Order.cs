using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class Order
    {
        public Order()
        {
            this.ExportFormTP_KD = new List<ExportFormTP_KD>();
            this.WorkOrders = new List<WorkOrder>();
            this.OrderDetails = new List<OrderDetail>();
            this.Orders1 = new List<Order>();
        }

        public long OrderId { get; set; }
        public Nullable<long> ParentOrderId { get; set; }
        public int CustomerId { get; set; }
        public Nullable<int> SalesPersonId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public System.DateTime OrderDate { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public Nullable<System.DateTime> ShippedDate { get; set; }
        public byte Status { get; set; }
        public string OrderNumber { get; set; }
        public string PoNumber { get; set; }
        public string LotNumber { get; set; }
        public string ModelNumber { get; set; }
        public string BillToAddress { get; set; }
        public string ShipToAddress { get; set; }
        public Nullable<int> ShipMethodId { get; set; }
        public Nullable<byte> ShipmentDay { get; set; }
        public string Note { get; set; }
        public string CurrencyCode { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> PaymentTermId { get; set; }
        public Nullable<System.DateTime> ApprovedDate { get; set; }
        public string ApprovedUser { get; set; }
        public virtual ICollection<ExportFormTP_KD> ExportFormTP_KD { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<Order> Orders1 { get; set; }
        public virtual Order Order1 { get; set; }
    }
}
