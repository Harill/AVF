using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models {
    public class ProductInvStatisticModel {
        public ProductInvStatisticModel() {
            Detail1 = new ProductInvStatisticDetailModel();
            Detail2 = new ProductInvStatisticDetailModel();
            Detail3 = new ProductInvStatisticDetailModel();
            Detail4 = new ProductInvStatisticDetailModel();
            Detail5 = new ProductInvStatisticDetailModel();
            Detail6 = new ProductInvStatisticDetailModel();
            Detail7 = new ProductInvStatisticDetailModel();
            Detail8 = new ProductInvStatisticDetailModel();
            Detail9 = new ProductInvStatisticDetailModel();
            Detail10 = new ProductInvStatisticDetailModel();
        }
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public ProductInvStatisticDetailModel Detail1 { get; set; }
        public ProductInvStatisticDetailModel Detail2 { get; set; }
        public ProductInvStatisticDetailModel Detail3 { get; set; }
        public ProductInvStatisticDetailModel Detail4 { get; set; }
        public ProductInvStatisticDetailModel Detail5 { get; set; }
        public ProductInvStatisticDetailModel Detail6 { get; set; }
        public ProductInvStatisticDetailModel Detail7 { get; set; }
        public ProductInvStatisticDetailModel Detail8 { get; set; }
        public ProductInvStatisticDetailModel Detail9 { get; set; }
        public ProductInvStatisticDetailModel Detail10 { get; set; }
    }

    public class ProductInvStatisticDetailModel {
        public double Weight { get; set; }
        public double Import { get; set; }
        public double Export { get; set; }
    }
}