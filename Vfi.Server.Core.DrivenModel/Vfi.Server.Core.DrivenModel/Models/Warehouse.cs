using System;
using System.Collections.Generic;

namespace Vfi.Server.Core.DrivenModel.Models
{
    public partial class Warehouse
    {
        public Warehouse()
        {
            MachineAppraisals = new List<MachineAppraisal>();
            MaterialInventories = new List<MaterialInventory>();
            MaterialInventoryPeriods = new List<MaterialInventoryPeriod>();
            ProductInventories = new List<ProductInventory>();
            ProductInventoryPeriods = new List<ProductInventoryPeriod>();
            StockOrders = new List<StockOrder>();
            StockOrders1 = new List<StockOrder>();
            Transactions = new List<Transaction>();
            Transactions1 = new List<Transaction>();
            TimeLines = new List<TimeLine>();
        }

        public int WarehouseId { get; set; }
        public Nullable<int> WarehouseTypeId { get; set; }
        public string WarehouseName { get; set; }
        public string Description { get; set; }
        public int Idx { get; set; }
        public bool DisplayInReport { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual ICollection<MachineAppraisal> MachineAppraisals { get; set; }
        public virtual ICollection<MaterialInventory> MaterialInventories { get; set; }
        public virtual ICollection<MaterialInventoryPeriod> MaterialInventoryPeriods { get; set; }
        public virtual ICollection<ProductInventory> ProductInventories { get; set; }
        public virtual ICollection<ProductInventoryPeriod> ProductInventoryPeriods { get; set; }
        public virtual ICollection<StockOrder> StockOrders { get; set; }
        public virtual ICollection<StockOrder> StockOrders1 { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual ICollection<Transaction> Transactions1 { get; set; }
        public virtual ICollection<TimeLine> TimeLines { get; set; }
        public virtual WarehouseType WarehouseType { get; set; }
    }
}
