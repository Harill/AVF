using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class InventoryDrawer
    {
        public InventoryDrawer() {
            this.OnShelves = new List<OnShelf>();
            this.TransactionDetails = new List<TransactionDetail>();
        }

        public int DrawerId { get; set; }
        public int ShelfId { get; set; }
        public string ColumnName { get; set; }
        public string RowName { get; set; }
        public bool Active { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<int> ReferenceId { get; set; }
        public Nullable<int> ReferenceInvId { get; set; }
        public string AdditionName { get; set; }
        public virtual InventoryShelf InventoryShelf { get; set; }
        public virtual ICollection<OnShelf> OnShelves { get; set; }
        public virtual ICollection<TransactionDetail> TransactionDetails { get; set; }
    }
}
