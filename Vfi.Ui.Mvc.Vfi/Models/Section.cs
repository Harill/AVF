using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class Section
    {
        public Section()
        {
            this.ProductionSections = new List<ProductionSection>();
            this.SectionProcessDetails = new List<SectionProcessDetail>();
        }

        public int SectionId { get; set; }
        public string SectionName { get; set; }
        public double SaleFactor { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<ProductionSection> ProductionSections { get; set; }
        public virtual ICollection<SectionProcessDetail> SectionProcessDetails { get; set; }
    }
}
