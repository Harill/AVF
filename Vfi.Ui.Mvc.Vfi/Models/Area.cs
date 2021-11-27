using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class Area
    {
        public Area()
        {
            this.Customers = new List<Customer>();
        }

        public int AreaId { get; set; }
        public string Description { get; set; }
        public string AreaName { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
