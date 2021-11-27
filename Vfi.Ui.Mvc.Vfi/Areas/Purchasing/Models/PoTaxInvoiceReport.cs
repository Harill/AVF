using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Purchasing.Models
{
    public class PoTaxInvoiceReport
    {
        public PoTaxInvoiceReport()
        {
            ImportLastMonths = new List<ImportPoReport>();
            ImportInMonths = new List<ImportPoReport>();
            LastMonthRequireUsd = 0;
            LastMonthRequireVnd = 0;
            InMonthTaxInvoiceVnd = 0;
            InMonthTaxInvoiceUsd = 0;
            ReceiveInMonthVnd = 0;
            ReceiveInMonthUsd = 0;
            ReduceInMonthVnd = 0;
            ReduceInMonthUsd = 0;
        }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int Index { get; set; }
        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public int ClassifiedId { get; set; }
        public string ClassifiedName { get; set; }
        public string CurrencyCode { get; set; }
        public int TaxPercent { get; set; }
        public int ExchangeRate { get; set; }

        public List<ImportPoReport> ImportInMonths { get; set; }
        public List<ImportPoReport> ImportLastMonths { get; set; }

        //1
        public double LastMonthInvoiceNoTaxInvoiceVnd
        {
            get { return Math.Round(ImportLastMonths.Sum(ed => ed.AmountVnd + ed.Tax), 0); }
        }

        public double LastMonthInvoiceNoTaxInvoiceUsd
        {
            get { return Math.Round(ImportLastMonths.Sum(ed => ed.Amount + ed.Tax), 2); }
        }

        //2
        public double LastMonthRequireVnd { get; set; }
        public double LastMonthRequireUsd { get; set; }
        //3 = 1 + 2
        public double LastMonthTotalVnd
        {
            get { return Math.Round(LastMonthInvoiceNoTaxInvoiceVnd + LastMonthRequireVnd, 0); }
        }

        public double LastMonthTotalUsd
        {
            get { return Math.Round(LastMonthInvoiceNoTaxInvoiceUsd + LastMonthRequireUsd, 2); }
        }

        //4
        public double InMonthInvoiceVnd
        {
            get { return Math.Round(ImportInMonths.Sum(ed => ed.AmountVnd), 0); }
        }
        public double Tax
        {
            get { return Math.Round(ImportInMonths.Sum(ed => ed.Tax), 0); }
        }
        public double InMonthInvoiceUsd
        {
            get { return Math.Round(ImportInMonths.Sum(ed => ed.Amount), 2); }
        }

        //5
        public double InMonthTaxInvoiceVnd { get; set; }
        public double InMonthTaxInvoiceUsd { get; set; }
        // 6
        public double ReceiveInMonthVnd { get; set; }
        public double ReceiveInMonthUsd { get; set; }
        //7
        public double ReduceInMonthVnd { get; set; }
        public double ReduceInMonthUsd { get; set; }
        public double TotalExportQuantity
        {
            get { return ImportInMonths.Sum(ed => ed.Quantity); }
        }


        //8 = 1 + 4 - 5
        public double SumInvoiceNoTaxInvoiceVnd
        {
            get { return Math.Round(LastMonthInvoiceNoTaxInvoiceVnd + InMonthInvoiceVnd + Tax - InMonthTaxInvoiceVnd, 0); }
        }

        public double SumInvoiceNoTaxInvoiceUsd
        {
            get { return Math.Round(LastMonthInvoiceNoTaxInvoiceUsd + InMonthInvoiceUsd - InMonthTaxInvoiceUsd, 2); }
        }

        //9 = 2 + 5 - 6 - 7
        public double SumRequireVnd
        {
            get { return Math.Round(LastMonthRequireVnd + InMonthTaxInvoiceVnd - ReceiveInMonthVnd - ReduceInMonthVnd, 0); }
        }

        public double SumRequireUsd
        {
            get { return Math.Round(LastMonthRequireUsd + InMonthTaxInvoiceUsd - ReceiveInMonthUsd - ReduceInMonthUsd, 2); }
        }

        //10 = 8 + 9
        public double SumTotalVnd
        {
            get { return Math.Round(SumInvoiceNoTaxInvoiceVnd + SumRequireVnd, 0); }
        }

        public double SumTotalUsd
        {
            get { return Math.Round(SumInvoiceNoTaxInvoiceUsd + SumRequireUsd, 2); }
        }
        public bool Show
        {
            get
            {
                return LastMonthTotalVnd + LastMonthTotalUsd + //3
                       InMonthInvoiceVnd + InMonthInvoiceUsd + //4
                       InMonthTaxInvoiceVnd + InMonthTaxInvoiceUsd + //5 
                       ReceiveInMonthVnd + ReceiveInMonthUsd + //6
                       ReduceInMonthVnd + ReduceInMonthUsd + //7
                       TotalExportQuantity > 0;
            }
        }
    }

    public class ImportPoReport
    {
        public ImportPoReport()
        {
            Quantity = 0;
            UnitPrice = 0;
            TaxPercent = 0;
        }

        public double Quantity { get; set; }
        public double UnitPrice { get; set; }
        public int TaxPercent { get; set; }
        public int ExchangeRate { get; set; }
        public string CurrencyCode { get; set; }

        public double AmountVnd
        {
            get { return !CurrencyCode.Equals("USD") ? Math.Round(Quantity*UnitPrice, 0) : 0; }
        }

        public double Amount
        {
            get { return CurrencyCode.Equals("USD") ? Math.Round(Quantity*UnitPrice, 2) : 0; }
        }

        public double Tax
        {
            get
            {
                return !CurrencyCode.Equals("USD")
                           ? AmountVnd*TaxPercent/100
                           : Amount*TaxPercent/100;
            }
        }
    }

}