using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class TransactionWeighing
    {
        public int WeighingId { get; set; }
        public int ProductId { get; set; }
        public int WarehouseId { get; set; }
        public double UnitWeight { get; set; }
        public double PackageWeight { get; set; }
        public double Weight { get; set; }
        public double Quantity { get; set; }
        public Nullable<long> TransactionId { get; set; }
        public byte Status { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public virtual Transaction Transaction { get; set; }
        public virtual Product Product { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
