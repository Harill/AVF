using System;
using System.Collections.Generic;

namespace Vfi.Server.Core.DrivenModel.Models
{
    public partial class WarehouseType
    {
        public WarehouseType()
        {
            Warehouses = new List<Warehouse>();
        }

        public int WarehouseTypeId { get; set; }
        public string WarehouseTypeName { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual ICollection<Warehouse> Warehouses { get; set; }
    }
}
