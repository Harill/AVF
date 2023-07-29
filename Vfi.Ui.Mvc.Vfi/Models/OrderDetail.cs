using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class OrderDetail
    {
        public OrderDetail()
        {
            this.WorkOrders = new List<WorkOrder>();
            this.ExportFormTP_KDDetail = new List<ExportFormTP_KDDetail>();
            this.OrderProgresses = new List<OrderProgress>();
            this.InvoiceDetails = new List<InvoiceDetail>();
            this.OrderStatuses = new List<OrderStatus>();
            this.TimeLines = new List<TimeLine>();
        }

        public long OrderDetailId { get; set; }
        public long OrderId { get; set; }
        public int ProductId { get; set; }
        public string CarrierTrackingNumber { get; set; }
        public Nullable<int> OrderQty { get; set; }
        public double UnitPrice { get; set; }
        public double UnitPriceDiscount { get; set; }
        public double LineTotal { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<System.DateTime> VFIDueDate { get; set; }
        public Nullable<System.DateTime> CustomerDueDate { get; set; }
        public string LotNumber { get; set; }
        public string ModelNumber { get; set; }
        public Nullable<int> Status { get; set; }
        public string PONumber { get; set; }
        public Nullable<bool> IsComplete { get; set; }
        public int RequiedNumber { get; set; }
        public string Note { get; set; }
        public string OrderNote { get; set; }
        public Nullable<bool> IsAlert { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
        public virtual ICollection<ExportFormTP_KDDetail> ExportFormTP_KDDetail { get; set; }
        public virtual ICollection<OrderProgress> OrderProgresses { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual Status Status1 { get; set; }
        public virtual ICollection<OrderStatus> OrderStatuses { get; set; }
        public virtual Order Order { get; set; }
        public virtual ICollection<TimeLine> TimeLines { get; set; }
    }
}
