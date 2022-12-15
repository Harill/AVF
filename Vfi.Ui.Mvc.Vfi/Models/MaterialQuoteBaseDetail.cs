using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class MaterialQuoteBaseDetail
    {
        public int DetailId { get; set; }
        public int MaterialQuoteBaseId { get; set; }
        public double FromOutDiameter { get; set; }
        public double ToOutDiameter { get; set; }
        public double InDiameter { get; set; }
        public double Value { get; set; }
        public virtual MaterialQuoteBase MaterialQuoteBase { get; set; }
    }
}
