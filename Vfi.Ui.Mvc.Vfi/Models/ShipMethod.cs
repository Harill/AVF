using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ShipMethod
    {
        public ShipMethod()
        {
            this.Customers = new List<Customer>();
        }

        public int ShipMethodId { get; set; }
        public string Name { get; set; }
        public Nullable<double> ShipBase { get; set; }
        public Nullable<double> ShipRate { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
