using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class SelectGroupProductPeriod
    {
        public int ProductId { get; set; }
        public int WarehouseId { get; set; }
        public Nullable<double> TotalPeriod { get; set; }
    }
}
