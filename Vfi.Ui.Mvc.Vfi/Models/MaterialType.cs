using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class MaterialType
    {
        public MaterialType()
        {
            this.Tools = new List<Tool>();
            this.Materials = new List<Material>();
            this.MaterialQuoteBases = new List<MaterialQuoteBase>();
        }

        public int MaterialTypeId { get; set; }
        public int MaterialClassifiedId { get; set; }
        public string MaterialTypeName { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string IdentityCode { get; set; }
        public string DiagramColor { get; set; }
        public Nullable<double> Factor { get; set; }
        public Nullable<double> ProductionFactor { get; set; }
        public Nullable<double> TaxFactor { get; set; }
        public virtual ICollection<Tool> Tools { get; set; }
        public virtual ICollection<Material> Materials { get; set; }
        public virtual MaterialClassified MaterialClassified { get; set; }
        public virtual ICollection<MaterialQuoteBase> MaterialQuoteBases { get; set; }
    }
}
