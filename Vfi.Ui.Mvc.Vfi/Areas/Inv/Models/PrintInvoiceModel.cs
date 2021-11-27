using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class PrintInvoiceModel
    {
        public string InvoiceNumber { get; set; }
        public DateTime Today { get; set; }
        public int ProductId{get;set;}
        public string CustomerName { get; set; }
        public string CustomerInfo { get; set; }
        public string CustomerContact { get; set; }
        public string CustomerShipTo { get; set; }
        //so HD
        public string TaxInvoice { get; set; }
        public string ShiftmentDateString { get; set; }

        public string OrderNumber { get; set; }
        public string CurrencyCode { get; set; }

        public string ProductName { get; set; }
        public string ProductInfo { get; set; }
        public double Quantity { get; set; }
        public string UM { get; set; }
        public double UnitPrice { get; set; }
        public string Note { get; set; }

        public int TaxPercent { get; set; }

        public double Amount { get; set; }
        public double Weight { get; set; }
        public int Package { get; set; }

        public double TaxAmount { get; set; }
        public string PaymentTerm { get; set; }
    }
}