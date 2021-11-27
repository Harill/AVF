using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class ProductInventoryInDayModel
    {
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string CustomerCode { get; set; }
        public double FirstTotal { get; set; }
        public double LastTotal { get; set; }

        [DisplayName("Nhập kho 1")]
        public double Receipt1 { get; set; }
        [DisplayName("Nhập kho 2")]
        public double Receipt2 { get; set; }
        [DisplayName("Nhập kho 3")]
        public double Receipt3 { get; set; }
        [DisplayName("Nhập kho 4")]
        public double Receipt4 { get; set; }
        [DisplayName("Nhập kho 5")]
        public double Receipt5 { get; set; }
        [DisplayName("Nhập kho 6")]
        public double Receipt6 { get; set; }
        [DisplayName("Tổng nhập")]
        public double TotalReceipt { get; set; }
        [DisplayName("Xuất kho 1")]
        public double Issue1 { get; set; }
        [DisplayName("Xuất kho 2")]
        public double Issue2 { get; set; }
        [DisplayName("Xuất kho 3")]
        public double Issue3 { get; set; }
        [DisplayName("Xuất kho 4")]
        public double Issue4 { get; set; }
        [DisplayName("Xuất kho 5")]
        public double Issue5 { get; set; }
        [DisplayName("Xuất kho 6")]
        public double Issue6 { get; set; }
        [DisplayName("Tổng xuất")]
        public double TotalIssue { get; set; }
    }
}