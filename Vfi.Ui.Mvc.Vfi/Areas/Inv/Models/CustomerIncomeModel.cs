using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class CustomerIncomeModel {
        public CustomerIncomeModel() {
            Details = new List<CustomerIncomeDetailModel>();
        }
        public int CustomerId { get; set; }
        public string CustomerCodeName { get; set; }
        public double Total { get { return Details.Sum(d => d.Total); } }
        public double TotalVnd { get { return Details.Sum(d => d.TotalVnd); } }
        public double Tax { get { return Details.Sum(d => d.Tax); } }
        public double TaxVnd { get { return Details.Sum(d => d.TaxVnd); } }
        public string ReportDateString { get; set; }
        public List<CustomerIncomeDetailModel> Details { get; set; }

        public int ProductCount { get { return Details.Count; } }
        public double TotalQuatity { get { return Details.Sum(d => d.Quatity); } }


        public double TotalNoTaxInvoiceUsd {
            get {
                return
                    Details.Where(d => !d.CurrencyCode.Equals("VND") &&
                                       string.IsNullOrWhiteSpace(d.TaxInvoiceNumber))
                           .Sum(d => d.Total);
            }
        }
        public double TotalNoTaxInvoiceVnd {
            get {
                return
                    Details.Where(d => d.CurrencyCode.Equals("VND") &&
                                       string.IsNullOrWhiteSpace(d.TaxInvoiceNumber))
                           .Sum(d => d.Total);
            }
        }

        public double TotalTaxInvoiceUsd {
            get {
                return
                    Details.Where(d => !d.CurrencyCode.Equals("VND") &&
                                       !string.IsNullOrWhiteSpace(d.TaxInvoiceNumber))
                           .Sum(d => d.Total);
            }
        }
        public double TotalTaxInvoiceVnd {
            get {
                return
                    Details.Where(d => d.CurrencyCode.Equals("VND") &&
                                       !string.IsNullOrWhiteSpace(d.TaxInvoiceNumber))
                           .Sum(d => d.Total);
            }
        }
 
    }
    public class CustomerIncomeDetailModel
    {
        public CustomerIncomeDetailModel()
        {
            Quatity = 0;
            UnitPrice = 0;
            TaxPercent = 0;
            ExchangeRate = 1;
        }
        public Boolean HasTaxInvoice { get { return !string.IsNullOrWhiteSpace(TaxInvoiceNumber); } }
        public string TaxInvoiceNumber { get; set; }
        public string TaxInvoiceDateString { get; set; }
        public string PoNumber { get; set; }
        public string DueDateString { get; set; }
        public string InvoiceNumber { get; set; }
        public int ProductId { get; set; }
        public string ProductCodeName { get; set; }
        public double Quatity { get; set; }
        public double UnitPrice { get; set; }
        public double TaxPercent { get; set; }
        public double ExchangeRate { get; set; }
        public string CurrencyCode { get; set; }


        public double Total
        {
            get { return Quatity * UnitPrice; }
        }
        public double TotalVnd
        {
            get { return Math.Round(Total * ExchangeRate, 0); }
        }
        //public double TotalUsd
        //{
        //    get { return CurrencyCode.Equals("VND") ? 0 : Total*ExchangeRate; }
        //}
        public double Tax
        {
            get { return Total * TaxPercent / 100; }
        }

        public double TaxVnd
        {
            get { return Math.Round(Tax * ExchangeRate, 0); }
        }
    }
}