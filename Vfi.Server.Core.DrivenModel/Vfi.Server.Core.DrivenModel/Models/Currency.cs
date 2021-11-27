using System;
using System.Collections.Generic;

namespace Vfi.Server.Core.DrivenModel.Models
{
    public partial class Currency
    {
        public Currency()
        {
            PriceListMaterials = new List<PriceListMaterial>();
        }

        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual ICollection<PriceListMaterial> PriceListMaterials { get; set; }
    }
}
