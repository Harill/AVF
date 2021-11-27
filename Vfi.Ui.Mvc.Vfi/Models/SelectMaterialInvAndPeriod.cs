using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class SelectMaterialInvAndPeriod
    {
        public int MaterialInventoryId { get; set; }
        public int MaterialId { get; set; }
        public string MaterialCode { get; set; }
        public string LotNumber { get; set; }
        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public double TotalQuantity { get; set; }
        public Nullable<double> PeriodQuantity { get; set; }
    }
}
