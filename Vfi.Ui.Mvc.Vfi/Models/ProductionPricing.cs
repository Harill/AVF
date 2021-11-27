using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ProductionPricing
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ProductionCamesPricing { get; set; }
        public int ProductionCncPricing { get; set; }
        public int CncPricing { get; set; }
        public int Production2Pricing { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public int ProductionTeamDPricing { get; set; }
        public int ProductionTechnicalPricing { get; set; }
        public virtual Product Product { get; set; }
    }
}
