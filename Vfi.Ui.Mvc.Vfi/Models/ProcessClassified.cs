using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ProcessClassified
    {
        public ProcessClassified()
        {
            this.Products = new List<Product>();
        }

        public int ClassifiedId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double SalesFactor { get; set; }
        public bool Active { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
