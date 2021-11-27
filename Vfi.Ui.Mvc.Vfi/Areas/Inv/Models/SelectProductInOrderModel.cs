using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class SelectProductInOrderModel
    {
        public long DetailId { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public double RequiredNumber { get; set; }
        public double TotalQuanlity { get; set; }
    }

}