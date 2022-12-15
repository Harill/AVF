using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ProductionProductLevel
    {
        public ProductionProductLevel()
        {
            this.Products = new List<Product>();
        }

        public int LevelId { get; set; }
        public string LevelName { get; set; }
        public double Factor { get; set; }
        public bool Active { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
