using System;
using System.Collections.Generic;

namespace Vfi.Server.Core.DrivenModel.Models
{
    public partial class MaterialType
    {
        public MaterialType()
        {
            Materials = new List<Material>();
            PurchaseOrderDetails = new List<PurchaseOrderDetail>();
        }

        public int MaterialTypeId { get; set; }
        public int MaterialClassifiedId { get; set; }
        public string MaterialTypeName { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual ICollection<Material> Materials { get; set; }
        public virtual MaterialClassified MaterialClassified { get; set; }
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
    }
}
