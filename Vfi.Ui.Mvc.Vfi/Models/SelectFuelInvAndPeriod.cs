using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class SelectFuelInvAndPeriod
    {
        public int FuelInvId { get; set; }
        public int FuelId { get; set; }
        public string FuelFullCode { get; set; }
        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public double TotalQuantity { get; set; }
        public string LotNumber { get; set; }
        public Nullable<double> PeriodQuantity { get; set; }
    }
}
