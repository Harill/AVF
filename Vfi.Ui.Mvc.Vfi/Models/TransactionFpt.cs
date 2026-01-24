using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class TransactionFpt
    {
        public TransactionFpt()
        {
            this.ExportTools = new List<ExportTool>();
            this.FuelInventoryPeriods = new List<FuelInventoryPeriod>();
            this.ToolInventoryPeriods = new List<ToolInventoryPeriod>();
            this.ToolInvOnMachinePeriods = new List<ToolInvOnMachinePeriod>();
            this.TransactionFptDetails = new List<TransactionFptDetail>();
        }

        public long TransactionId { get; set; }
        public string TransactionCode { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public byte Status { get; set; }
        public int Type { get; set; }
        public int EoI { get; set; }
        public int Fpt { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<long> PoId { get; set; }
        public byte InventorySignature { get; set; }
        public byte QcSignature { get; set; }
        public byte PurchasingSignature { get; set; }
        public byte AccountantSignature { get; set; }
        public double ExchangeRate { get; set; }
        public Nullable<bool> IsInternal { get; set; }
        public virtual ICollection<ExportTool> ExportTools { get; set; }
        public virtual ICollection<FuelInventoryPeriod> FuelInventoryPeriods { get; set; }
        public virtual ICollection<ToolInventoryPeriod> ToolInventoryPeriods { get; set; }
        public virtual ICollection<ToolInvOnMachinePeriod> ToolInvOnMachinePeriods { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }
        public virtual ICollection<TransactionFptDetail> TransactionFptDetails { get; set; }

    }
}
