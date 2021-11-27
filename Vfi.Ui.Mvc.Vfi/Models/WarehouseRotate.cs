using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class WarehouseRotate
    {
        public int RotateId { get; set; }
        public int WarehouseId { get; set; }
        public int ToWarehouseId { get; set; }
        public bool Active { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual Warehouse Warehouse1 { get; set; }
    }
}
