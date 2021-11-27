using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ProductionMaterial
    {
        public int RealMaterialId { get; set; }
        public int ProductId { get; set; }
        public int MaterialId { get; set; }
        public int Priority { get; set; }
        public string Note { get; set; }
        public double UnitWeightByMaterial { get; set; }
        public bool Active { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public virtual Material Material { get; set; }
        public virtual Product Product { get; set; }
    }
}
