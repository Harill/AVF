using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Purchasing.Models
{
    public class PoTaxInvoiceReferenceDetailModel
    {

        public PoTaxInvoiceReferenceDetailModel()
        {
            CurrencyCode = "";
            UnitPrice = 0;
            Quantity = 0;
        }
        public int DetailId { get; set; }
        public int DetailReferenceId { get; set; }
        public int ReferenceId { get; set; }
        public string Code { get; set; }
        public double Quantity { get; set; }
        public double UnitPrice { get; set; }
        public string Unit { get; set; }
        public long ImportId { get; set; }
        public long ImportDetailId { get; set; }
        public string ImportCode { get; set; }
        [DataType("_DateTemplate")]
        public DateTime? ImportDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public bool IsAdd { get; set; }
        public string CurrencyCode { get; set; }
        public int TaxPercent { get; set; }
        public int ExchangeRate { get; set; }
        public string Note { get; set; }
        public string UnitPriceFormat
        {
            get
            {
                return CurrencyCode.Equals("VND")
                           ? string.Format("{0:n0}", UnitPrice)
                           : string.Format("{0:n4}", UnitPrice);
            }
        }
        public double Amount { get { return Quantity * UnitPrice; } }
        public string AmountFormat
        {
            get
            {
                return CurrencyCode.Equals("VND")
                           ? string.Format("{0:n0}", Amount)
                           : string.Format("{0:n2}", Amount);
            }
        }
    }
}