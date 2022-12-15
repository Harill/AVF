using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ProductionProductivityQuoteBase
    {
        public int BaseId { get; set; }
        public int ProductId { get; set; }
        public int Idx { get; set; }
        public string Name { get; set; }
        public int Round { get; set; }
        public double L { get; set; }
        public double F { get; set; }
        public double Time { get; set; }
        public bool Active { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public virtual Product Product { get; set; }
    }
}
