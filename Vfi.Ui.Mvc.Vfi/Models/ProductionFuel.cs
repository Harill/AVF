using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ProductionFuel
    {
        public int RealId { get; set; }
        public int ProductId { get; set; }
        public int FuelId { get; set; }
        public int Priority { get; set; }
        public string Note { get; set; }
        public bool Active { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public int Quota { get; set; }
        public int Quota2 { get; set; }
        public Nullable<int> Fuel2Id { get; set; }
        public double CrossWeight { get; set; }
        public double CrossWeight2 { get; set; }
        public virtual Fuel Fuel { get; set; }
        public virtual Fuel Fuel1 { get; set; }
        public virtual Product Product { get; set; }
    }
}
