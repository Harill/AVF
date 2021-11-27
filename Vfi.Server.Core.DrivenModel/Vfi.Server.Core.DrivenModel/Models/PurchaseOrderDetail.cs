using System;
using System.Collections.Generic;

namespace Vfi.Server.Core.DrivenModel.Models
{
    public partial class PurchaseOrderDetail
    {
        public long PurchaseOrderDetailId { get; set; }
        public long PurchaseOrderId { get; set; }
        public int MaterialClassifiedId { get; set; }
        public int MaterialTypeId { get; set; }
        public int MaterialId { get; set; }
        public short OrderQty { get; set; }
        public double UnitPrice { get; set; }
        public double LineTotal { get; set; }
        public double ReceivedQty { get; set; }
        public double RejectedQty { get; set; }
        public double StockedQty { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual Material Material { get; set; }
        public virtual MaterialClassified MaterialClassified { get; set; }
        public virtual MaterialType MaterialType { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }
    }
}
