using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class TrackUpMaterial
    {
        public int DetailId { get; set; }
        public int TrackId { get; set; }
        public int MaterialInvId { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public string Note { get; set; }
        public virtual TrackUpMachine TrackUpMachine { get; set; }
        public virtual MaterialInventory MaterialInventory { get; set; }
    }
}
