using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ShipMethod
    {
        public int ShipMethodId { get; set; }
        public string Name { get; set; }
        public Nullable<double> ShipBase { get; set; }
        public Nullable<double> ShipRate { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
