using System;
using System.Collections.Generic;

namespace Vfi.Server.Core.DrivenModel.Models
{
    public partial class PriceListMaterial
    {
        public long PriceListMaterialId { get; set; }
        public int MaterialId { get; set; }
        public Nullable<double> NetPrice { get; set; }
        public string Currency { get; set; }
        public Nullable<double> Exchange { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual Currency Currency1 { get; set; }
        public virtual Material Material { get; set; }
    }
}
