using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ProductionDefectType
    {
        public ProductionDefectType()
        {
            this.ProductionDefects = new List<ProductionDefect>();
        }

        public int DefectTypeId { get; set; }
        public string DefectTypeName { get; set; }
        public string DefectTypeCode { get; set; }
        public string Description { get; set; }
        public string ModifiedUser { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<ProductionDefect> ProductionDefects { get; set; }
    }
}
