using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class InventoryShelf
    {
        public InventoryShelf()
        {
            this.InventoryDrawers = new List<InventoryDrawer>();
        }

        public int ShelfId { get; set; }
        public string ShelfName { get; set; }
        public int ClassifiedId { get; set; }
        public Nullable<int> WarehouseId { get; set; }
        public int MaxColumn { get; set; }
        public int MaxRow { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<InventoryDrawer> InventoryDrawers { get; set; }
        public virtual MaterialClassified MaterialClassified { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
