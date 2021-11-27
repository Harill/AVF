using System;
using System.Collections.Generic;

namespace Vfi.Server.Core.DrivenModel.Models
{
    public partial class StockOrderType
    {
        public int StockOrderTypeId { get; set; }
        public string StockOrderTypeName { get; set; }
        public bool EoI { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
