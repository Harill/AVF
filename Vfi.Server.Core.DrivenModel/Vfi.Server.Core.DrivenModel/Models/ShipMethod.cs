using System;
using System.Collections.Generic;

namespace Vfi.Server.Core.DrivenModel.Models
{
    public partial class ShipMethod
    {
        public ShipMethod()
        {
            PurchaseOrders = new List<PurchaseOrder>();
        }

        public int ShipMethodId { get; set; }
        public string Name { get; set; }
        public Nullable<double> ShipBase { get; set; }
        public Nullable<double> ShipRate { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
}
