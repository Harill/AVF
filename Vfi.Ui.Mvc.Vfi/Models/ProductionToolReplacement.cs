using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ProductionToolReplacement
    {
        public int ReplaceId { get; set; }
        public int TrackId { get; set; }
        public Nullable<int> ToolId { get; set; }
        public int ProductionToolId { get; set; }
        public string Note { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public int PrepareQuantity { get; set; }
        public virtual Tool Tool { get; set; }
        public virtual TrackUpMachine TrackUpMachine { get; set; }
    }
}
