using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class MaterialQuoteBase
    {
        public MaterialQuoteBase()
        {
            this.MaterialQuoteBaseDetails = new List<MaterialQuoteBaseDetail>();
        }

        public int BaseId { get; set; }
        public int MaterialTypeId { get; set; }
        public string MaterialName { get; set; }
        public string MaterialShape { get; set; }
        public string MaterialDiameterType { get; set; }
        public double BasePrice { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public virtual MaterialType MaterialType { get; set; }
        public virtual ICollection<MaterialQuoteBaseDetail> MaterialQuoteBaseDetails { get; set; }
    }
}
