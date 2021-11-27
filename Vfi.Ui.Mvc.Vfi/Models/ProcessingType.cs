using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ProcessingType
    {
        public ProcessingType()
        {
            this.Machines = new List<Machine>();
            this.Products = new List<Product>();
        }

        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<double> ProcessingFactor { get; set; }
        public Nullable<double> ProcessingSaleFactor { get; set; }
        public Nullable<int> ForWarehouseId { get; set; }
        public virtual ICollection<Machine> Machines { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
