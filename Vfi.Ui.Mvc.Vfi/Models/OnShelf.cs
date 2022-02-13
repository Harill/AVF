using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class OnShelf
    {
        public int OnShelfId { get; set; }
        public int DrawerId { get; set; }
        public int ReferenceId { get; set; }
        public int ReferenceInvId { get; set; }
        public System.DateTime OnDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public virtual InventoryDrawer InventoryDrawer { get; set; }
    }
}
