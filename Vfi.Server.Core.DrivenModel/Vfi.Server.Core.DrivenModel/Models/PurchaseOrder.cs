using System;
using System.Collections.Generic;

namespace Vfi.Server.Core.DrivenModel.Models
{
    public partial class PurchaseOrder
    {
        public PurchaseOrder()
        {
            PurchaseOrderDetails = new List<PurchaseOrderDetail>();
        }

        public long PurchaseOrderId { get; set; }
        public int VendorId { get; set; }
        public int ShipMethodId { get; set; }
        public int EmployeeId { get; set; }
        public string RevisionNumber { get; set; }
        public byte Status { get; set; }
        public System.DateTime OrderDate { get; set; }
        public Nullable<System.DateTime> ShipDate { get; set; }
        public double SubTotal { get; set; }
        public double TaxAmt { get; set; }
        public double Freight { get; set; }
        public double TotalDue { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ShipMethod ShipMethod { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
    }
}
