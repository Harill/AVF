using System;
using System.Collections.Generic;

namespace Vfi.Server.Core.DrivenModel.Models
{
    public partial class MaterialInventory
    {
        public int MaterialInventoryId { get; set; }
        public int MaterialId { get; set; }
        public int WarehouseId { get; set; }
        public Nullable<double> TotalQty { get; set; }
        public Nullable<double> TotalQtyKg { get; set; }
        public Nullable<double> AvailableQty { get; set; }
        public Nullable<double> UnavailableQty { get; set; }
        public string UnitMeasure { get; set; }
        public byte Status { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual Material Material { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
