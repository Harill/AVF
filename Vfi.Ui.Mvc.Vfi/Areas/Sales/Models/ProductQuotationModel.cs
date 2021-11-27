using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Sales.Models
{
    public class ProductQuotationModel
    {
        public int QuoteDetailId { get; set; }
        [DataType("NumberAll")]
        public double LastDiff { get; set; }
        [DataType("Number")]
        public double QuotationCost { get; set; }
        [DataType("Number")]
        public double Quantity { get; set; }
        public string Note { get; set; }

        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductCustomerCode { get; set; }
        public string Dimension { get; set; }
        public string ProductPlating { get; set; }
        public double ProductWeight { get; set; }
        public string MaterialDesign { get; set; }
        [DataType("Number")]
        public double MaterialPrice { get; set; }
        [DataType("Number")]
        public double MaterialUnitPrice { get; set; }
        [DataType("Number")]
        public double ProcessingPrice { get; set; }

        public int CustomerId { get; set; }
        public string CustomerCodeName { get; set; }
        public string CustomerName { get; set; }
        public string ContactName { get; set; }
        public string CompanyName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerFax { get; set; }
        public string CustomerEmail { get; set; }

        public int QuoteId { get; set; }
        public string QuoteNumber { get; set; }
        public int QuoteRev { get; set; }
        public DateTime QuoteDate { get; set; }
        public DateTime EndDate { get; set; }
        public string CurrencyCode { get; set; }
        public string SalesPerson { get; set; }
        public string DeliveryTermName { get; set; }
        public string PaymentMethodName { get; set; }
        public string DeliveryPeriodName { get; set; }
        public string PaymentConditionName { get; set; }

    }
}