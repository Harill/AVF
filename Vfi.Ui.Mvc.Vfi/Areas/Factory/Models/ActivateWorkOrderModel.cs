using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models {
    public class ActivateWorkOrderModel {

        public int ProductId { get; set; }
        public string ProductCode { get; set; }

        public long OrderId { get; set; }
        public string OrderNumber { get; set; }
        public long OrderDetailId { get; set; }
        public DateTime DueDate { get; set; }

        public double OrderQuantity { get; set; }
        public double WorkOrderQuantity { get; set; }
        public double GoodQuantity { get; set; }
        public double NGQuantity { get; set; }
        public double DefectQuantit { get; set; }

        public int Status { get; set; }
        public string StatusName { get; set; }

        public int WorkOrderCount { get; set; }
        public double TotalInv { get; set; }

    }

}