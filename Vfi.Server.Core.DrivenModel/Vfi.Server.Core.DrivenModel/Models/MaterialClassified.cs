using System;
using System.Collections.Generic;

namespace Vfi.Server.Core.DrivenModel.Models
{
    public partial class MaterialClassified
    {
        public MaterialClassified()
        {
            MaterialTypes = new List<MaterialType>();
            PurchaseOrderDetails = new List<PurchaseOrderDetail>();
        }

        public int MaterialClassifiedId { get; set; }
        public string MaterialClassifiedName { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual ICollection<MaterialType> MaterialTypes { get; set; }
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
    }
}
