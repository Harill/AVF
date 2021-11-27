using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class WarehousePermission
    {
        public int Id { get; set; }
        public Nullable<int> WarehouseId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<bool> Import { get; set; }
        public Nullable<bool> Rotate { get; set; }
        public Nullable<bool> OrderProgress { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual User User { get; set; }
    }
}
