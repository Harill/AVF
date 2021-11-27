using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class SectionProcess
    {
        public SectionProcess()
        {
            this.ProductionSectionProcesses = new List<ProductionSectionProcess>();
            this.ProductionSectionProcesses1 = new List<ProductionSectionProcess>();
            this.SectionProcessDetails = new List<SectionProcessDetail>();
            this.SectionProcessInventories = new List<SectionProcessInventory>();
            this.SectionProcessTransactionDetails = new List<SectionProcessTransactionDetail>();
            this.SectionProcessTransactionDetails1 = new List<SectionProcessTransactionDetail>();
        }

        public int ProcessId { get; set; }
        public string ProcessName { get; set; }
        public int ProductId { get; set; }
        public bool Active { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public bool StartProcess { get; set; }
        public bool EndProcess { get; set; }
        public virtual ICollection<ProductionSectionProcess> ProductionSectionProcesses { get; set; }
        public virtual ICollection<ProductionSectionProcess> ProductionSectionProcesses1 { get; set; }
        public virtual ICollection<SectionProcessDetail> SectionProcessDetails { get; set; }
        public virtual ICollection<SectionProcessInventory> SectionProcessInventories { get; set; }
        public virtual ICollection<SectionProcessTransactionDetail> SectionProcessTransactionDetails { get; set; }
        public virtual ICollection<SectionProcessTransactionDetail> SectionProcessTransactionDetails1 { get; set; }
    }
}
