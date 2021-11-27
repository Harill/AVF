using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class QuoteDetail
    {
        public int DetailId { get; set; }
        public int ProductId { get; set; }
        public double Diff { get; set; }
        public double MaterialPrice { get; set; }
        public double Quantity { get; set; }
        public string Note { get; set; }
        public Nullable<int> QuoteId { get; set; }
        public double QuoteCost { get; set; }
        public double ProcessingCost { get; set; }
        public double ProductWeight { get; set; }
        public string MaterialDesign { get; set; }
        public string Dimension { get; set; }
        public virtual Product Product { get; set; }
        public virtual QuoteForm QuoteForm { get; set; }
    }
}
