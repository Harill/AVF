using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ForecastOrder
    {
        public ForecastOrder()
        {
            this.ForecastOrderDetails = new List<ForecastOrderDetail>();
        }

        public int ForecastOrderId { get; set; }
        public int ProductId { get; set; }
        public System.DateTime ForecastDate { get; set; }
        public double Quantity { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> MaterialEnoughDate { get; set; }
        public bool IsSelling { get; set; }
        public byte Status { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<ForecastOrderDetail> ForecastOrderDetails { get; set; }
    }
}
