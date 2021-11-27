using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Purchasing.Models
{
    public class PoTaxInvoiceModel
    {public PoTaxInvoiceModel()
    {
        CurrencyCode = "";
        Total = 0;
        ExchangeRate = 1;
        TaxPercent = 0;
        Required = 0;
    }
        public int TaxInvoiceId { get; set; }
        public string TaxInvoiceNumber { get; set; }
        public string CurrencyCode { get; set; }
        public int ExchangeRate { get; set; }
        public int ClassifiedId { get; set; }
        public string ClassifiedName { get; set; }
        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public string Note { get; set; }
        public byte Status { get; set; }
        public string StatusName { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public int TaxPercent { get; set; }
        public DateTime PoDate { get; set; }
        public double Total { get; set; }
        public string TotalFormat
        {
            get
            {
                return CurrencyCode.Equals("VND")
                           ? string.Format("{0:n0}", Total)
                           : string.Format("{0:n2}", Total);
            }
        }
        public double TotalVnd { get { return Total*ExchangeRate; } }
        public double TotalQuantity { get; set; }
        public double Required{ get; set; }
        public string RequiredFormat
        {
            get
            {
                return CurrencyCode.Equals("VND")
                           ? string.Format("{0:n0}", Required)
                           : string.Format("{0:n2}", Required);
            }
        }
        [DataType("Number2")]
        public double Money { get; set; }
        public string MoneyFormat
        {
            get
            {
                return CurrencyCode.Equals("VND")
                           ? string.Format("{0:n0}", Money)
                           : string.Format("{0:n2}", Money);
            }
        }
        public double Reduce { get; set; }
        public string ReduceFormat
        {
            get
            {
                return CurrencyCode.Equals("VND")
                           ? string.Format("{0:n0}", Reduce)
                           : string.Format("{0:n2}", Reduce);
            }
        }
    }
}