using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Purchasing.Models
{
    public class PoTaxInvoiceMoneyModel
    {public PoTaxInvoiceMoneyModel()
    {
        CurrencyCode = "";
        Required = 0;
    }
        public int DetailId { get; set; }
        public int TaxInvoiceId { get; set; }
        public double Money { get; set; }
        public int Times { get; set; }
        public bool IsReduce { get; set; }
        public byte Status { get; set; }
        public System.DateTime ImportDate { get; set; }
        public string Note { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public string CurrencyCode { get; set; }
        public string TaxInvoiceNumber { get; set; }
        public double Required { get; set; }
        public int TaxPercent { get; set; }
        public int ExchangeRate { get; set; }
        public string RequiredFormat
        {
            get
            {
                return CurrencyCode.Equals("VND")
                           ? string.Format("{0:n0}", Required)
                           : string.Format("{0:n2}", Required);
            }
        }
        public string MoneyFormat
        {
            get
            {
                return CurrencyCode.Equals("VND")
                           ? string.Format("{0:n0}", Money)
                           : string.Format("{0:n2}", Money);
            }
        }
    }
}