using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ExportToolDetail
    {
        public long ExportDetailId { get; set; }
        public long ExportId { get; set; }                   
        public Nullable<int> MachineId { get; set; }
        public double Quantity { get; set; }
        public int ToolInvId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<long> TransactionDetailId { get; set; }
        public virtual Machine Machine { get; set; }
        public virtual ExportTool ExportTool { get; set; }
        public virtual Product Product { get; set; }
        public virtual ToolInventory ToolInventory { get; set; }
        public virtual TransactionFptDetail TransactionFptDetail { get; set; }

        public string ToolLocation { get; set; }                                        // moi them (17/01/2026)

    }
}
