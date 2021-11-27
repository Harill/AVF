using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Areas.Inv.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Sales.Models {
    public class WaitingOrderBalancingPlanModel : ProductionBalancingModel {
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public int OrderDetailId { get; set; }
    }
}