using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class SectionProcessInventory
    {
        public SectionProcessInventory()
        {
            this.SectionProcessPeriods = new List<SectionProcessPeriod>();
        }

        public int InvId { get; set; }
        public int ProcessId { get; set; }
        public int ProductId { get; set; }
        public double TotalInv { get; set; }
        public double UnitWeight { get; set; }
        public string LotNumber { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual SectionProcess SectionProcess { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<SectionProcessPeriod> SectionProcessPeriods { get; set; }
    }
}
