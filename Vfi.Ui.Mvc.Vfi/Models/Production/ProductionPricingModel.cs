using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Models.Production {
    public class ProductionPricingModel {

        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }
        [UIHint("Int")]
        public int ProductionCamesPricing { get; set; }
        [UIHint("Int")]
        public int ProductionCncPricing { get; set; }
        [UIHint("Int")]
        public int Production2Pricing { get; set; }
        [UIHint("Int")]
        public int CncPricing { get; set; }
        [UIHint("Int")]
        public int ProductionTeamDPricing { get; set; }
        [UIHint("Int")]
        public int ProductionTechnicalPricing { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
    }
}