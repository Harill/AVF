using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Sales.Models
{
    public class TaxInvoiceModel
    {
        public int TaxInvoiceId { get; set; }
        public string InvoiceNumber { get; set; }
        public long InvoiceId { get; set; }
        public string CustomerCode { get; set; }
        public string TaxInvoiceList { get; set; }
        [DataType("NumberPossitive")]
        public double? TotalAmount { get; set; }

        public string TotalAmountFormat
        {
            get
            {
                return string.IsNullOrWhiteSpace(CurrencyCode)
                           ? ""
                           : CurrencyCode.Equals("VND")
                           ? string.Format("{0:n0}", TotalAmount)
                           : string.Format("{0:n2}", TotalAmount);
            }
        }

        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public string StatusName { get; set; }
        public string Note { get; set; }

        public int Tax { get; set; }
        [DisplayName("Ngày lập HĐ")]
        [UIHint("_DateTemplate")]
        public DateTime? SetupDate { get; set; }

        public string CurrencyCode { get; set; }
        [DataType("NumberPossitive")]
        public double RequiredAmount { get; set; }
        public string RequiredAmountFormat
        {
            get
            {
                return string.IsNullOrWhiteSpace(CurrencyCode)
                           ? ""
                           : CurrencyCode.Equals("VND")
                           ? string.Format("{0:n0}", RequiredAmount)
                           : string.Format("{0:n2}", RequiredAmount);
            }
        }

        [DataType("NumberPossitive")]
        public double TotalAmountVND { get; set; }
        [DataType("NumberPossitive")]
        public double RequiredAmountVND { get; set; }
        [DataType("NumberPossitive")]
        public double ExchangeRate { get; set; }

        [DataType("NumberPossitive")]
        public double? TotalQuantity { get; set; }
    }
}