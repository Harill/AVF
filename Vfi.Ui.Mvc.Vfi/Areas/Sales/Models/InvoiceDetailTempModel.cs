using System;
using System.ComponentModel.DataAnnotations;

namespace Vfi.Ui.Mvc.Vfi.Areas.Sales.Models
{
    public class InvoiceDetailTempModel
    {
        public InvoiceDetailTempModel()
        {
            Amount = 0;
            UnitPrice = 0;
            CurrencyCode="VND";
            ExchangeRate = 1;
            TaxPercent = 0;
            //ExportedDate = DateTime.Now;
        }
        public int ExportId { get; set; }
        public long DetailId { get; set; }
        [DataType("Number")]
        public double Quantity { get; set; }
        public double Receive { get; set; }
        [DataType("Number")]
        public double UnitPrice { get; set; }
        public double Amount { get; set; }
        public string AmountFormat
        {
            get
            {
                return CurrencyCode.Equals("VND")
                           ? string.Format("{0:n0}", Amount)
                           : string.Format("{0:n2}", Amount);
            }
        }

        [UIHint("_ProductCodeTaxTemplate")]
        public string ProductCode { get; set; }
        public string PONumber { get; set; }

        public string UnitPriceFormat
        {
            get
            {
                return CurrencyCode.Equals("VND")
                                 ? string.Format("{0:n0}", UnitPrice)
                                 : string.Format("{0:n4}", UnitPrice);
            }
        }

        public string Note { get; set; }
        public string TaxInvoiceList { get; set; }
        public string InvoiceNumber { get; set; }
        //[DataType("_DateTemplate")]
        public DateTime ExportedDate { get; set; }
        public string ExportedDateStr { get; set; }
        public DateTime SetupDate { get; set; }

        //
        public string CustomerName { get; set; }
        public string ProductName { get; set; }
        public string CurrencyCode { get; set; }
        public int ProductId { get; set; }

        public string OrderNumber { get; set; }
        public double ExchangeRate { get; set; }
        public int TaxPercent { get; set; }
        public double Tax { get; set; }
        public double TaxVnd { get; set; }
        public double AmountVnd { get; set; }
        public DateTime VFIDueDate { get; set; }
        public string VFIDueDateStr {
            get {
                return VFIDueDate != null
                                 ? string.Format("{0:dd/MM/yyyy}", VFIDueDate)
                                 : "";
            }
        }
        public long OrderDetailId { get; set; }
        public int ExportDetailId { get; set; }
        public bool IsAdd { get; set; }
    }
}