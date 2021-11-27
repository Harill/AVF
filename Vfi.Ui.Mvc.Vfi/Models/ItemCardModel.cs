using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public class ItemCardModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string ProductCustomerCode { get; set; }
        public DateTime Date { get; set; }
        public string EmployeeName { get; set; }
        public double Quantity { get; set; }
        public string Lot { get; set; }
        public string Note { get; set; }
        public int FuelId { get; set; }
        public string FuelCode { get; set; }
    }
    public class PrintItemCardModel
    {
        public ItemCardModel ItemCard1 { get; set; }
        public ItemCardModel ItemCard2 { get; set; }
    }
}