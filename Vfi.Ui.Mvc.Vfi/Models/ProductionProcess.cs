using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ProductionProcess
    {
        public int ProcessId { get; set; }
        public int WarehouseId { get; set; }
        public int ProductId { get; set; }
        public bool IsAlert { get; set; }
        public bool IsNecessary { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public int ProcessIndex { get; set; }
        public string Note { get; set; }
        public virtual Product Product { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
