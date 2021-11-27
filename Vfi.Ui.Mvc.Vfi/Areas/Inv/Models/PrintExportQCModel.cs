using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class PrintExportQCModel
    {
        public string DeliveryDate { get; set; }
        public string ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public string TransactionCode { get; set; }
        public int DetailId { get; set; }
        public int ExportId { get; set; }
        public int ProductId { get; set; }
        public int Box { get; set; }
        public double Weight { get; set; }
        public double Number { get; set; }
        public string Note { get; set; }

        public string ProductCode { get; set; }
        public string CustomerCode { get; set; }
    }
}