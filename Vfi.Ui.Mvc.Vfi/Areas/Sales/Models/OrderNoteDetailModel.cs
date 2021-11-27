using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Sales.Models
{
    public class OrderNoteDetailModel
    {
        public int DetailId { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string CustomerCode { get; set; }
        public double Quantity { get; set; }
        public double Weight { get; set; }
        public string Note { get; set; }
    }
}