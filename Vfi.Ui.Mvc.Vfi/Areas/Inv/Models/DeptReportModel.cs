using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Areas.Sales.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class DeptReportModel
    {
        private List<DeptReportDetailModel> _details;

        public DeptReportModel()
        {
            Details = new List<DeptReportDetailModel>();
        }
        public string GroupCode { get; set; }
        public string GroupName { get; set; }
        public string ReportDate { get; set; }

        public List<DeptReportDetailModel> Details
        {
            //get { return _details.Where(d => d.Show).ToList(); }
            get { return _details; }
            set { _details = value; }
        }
       
        //1
        public double LastMonthInvoiceNoTaxInvoiceVND
        {
            get { return Details.Sum(d => d.LastMonthInvoiceNoTaxInvoiceVND); }
        }
        public double LastMonthInvoiceNoTaxInvoiceUSD
        {
            get { return Details.Sum(d => d.LastMonthInvoiceNoTaxInvoiceUSD); }
        }

        //2
        public double LastMonthRequireVND
        {
            get { return Details.Sum(d => d.LastMonthRequireVND); }
        }
        public double LastMonthRequireUSD
        {
            get { return Details.Sum(d => d.LastMonthRequireUSD); }
        }

        //3 = 1 + 2
        public double LastMonthTotalVND
        {
            get { return Details.Sum(d => d.LastMonthTotalVND); }
        }

        public double LastMonthTotalUSD
        {
            get { return Details.Sum(d => d.LastMonthTotalUSD); }
        }

        //4
        public double InMonthInvoiceVND
        {
            get { return Details.Sum(d => d.InMonthInvoiceVND); }
        }

        public double InMonthInvoiceUSD
        {
            get { return Details.Sum(d => d.InMonthInvoiceUSD); }
        }

        //5
        public double InMonthTaxInvoiceVND
        {
            get { return Details.Sum(d => d.InMonthTaxInvoiceVND); }
        }
        public double Tax
        {
            get { return Details.Sum(d => d.Tax); }
        }
        public double InMonthTaxInvoiceUSD
        {
            get { return Details.Sum(d => d.InMonthTaxInvoiceUSD); }
        }

        // 6
        public double ReceiveInMonthVND
        {
            get { return Details.Sum(d => d.ReceiveInMonthVND); }
        }
        public double ReceiveInMonthUSD
        {
            get { return Details.Sum(d => d.ReceiveInMonthUSD); }
        }

        // 7
        public double InMonthReduceVND
        {
            get { return Details.Sum(d => d.InMonthReduceVND); }
        }
        public double InMonthReduceUSD
        {
            get { return Details.Sum(d => d.InMonthReduceUSD); }
        }
        public double TotalExportQuantity
        {
            get { return Details.Sum(d => d.TotalExportQuantity); }
        }


        //8 = 1 + 4 - 5
        public double SumInvoiceNoTaxInvoiceVND
        {
            get { return Math.Round(LastMonthInvoiceNoTaxInvoiceVND + InMonthInvoiceVND  - InMonthTaxInvoiceVND, 0); }
        }

        public double SumInvoiceNoTaxInvoiceUSD
        {
            get { return Math.Round(LastMonthInvoiceNoTaxInvoiceUSD + InMonthInvoiceUSD  - InMonthTaxInvoiceUSD, 2); }
        }

        //9 = 2 + 5 - 6 - 7
        public double SumRequireVND
        {
            get { return Math.Round(LastMonthRequireVND + InMonthTaxInvoiceVND - ReceiveInMonthVND - InMonthReduceVND, 0); }
        }

        public double SumRequireUSD
        {
            get { return Math.Round(LastMonthRequireUSD + InMonthTaxInvoiceUSD - ReceiveInMonthUSD - InMonthReduceUSD, 2); }
        }

        //10 = 8 + 9
        public double SumTotalVND
        {
            get { return Math.Round(SumInvoiceNoTaxInvoiceVND + SumRequireVND, 0); }
        }

        public double SumTotalUSD
        {
            get { return Math.Round(SumInvoiceNoTaxInvoiceUSD + SumRequireUSD, 2); }
        }
    }

    public class DeptReportDetailModel
    {
        public DeptReportDetailModel()
        {
            LastMonthRequireVND = 0;
            LastMonthRequireUSD = 0;
            InMonthTaxInvoiceVND = 0;
            InMonthTaxInvoiceUSD = 0;
            ReceiveInMonthVND = 0;
            ReceiveInMonthUSD = 0;
            InMonthReduceVND = 0;
            InMonthReduceUSD = 0;
            ExportInMonths = new List<InvoiceDetailTempModel>();
            ExportLastMonths = new List<InvoiceDetailTempModel>();
        }

        public List<InvoiceDetailTempModel> ExportInMonths { get; set; }
        public List<InvoiceDetailTempModel> ExportLastMonths { get; set; }
        public string CustomerName { get; set; }
        public string PayType { get; set; }
        public int CustomerId { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        //1
        public double LastMonthInvoiceNoTaxInvoiceVND
        {
            get
            {
                return
                    Math.Round(ExportLastMonths.Sum(ed =>
                        ed.AmountVnd > 0
                            ?  ed.AmountVnd + ed.Tax
                            : 0), 2);
            }
        }

        public double LastMonthInvoiceNoTaxInvoiceUSD
        {
            get
            {
                return
                    Math.Round(ExportLastMonths.Sum(ed =>
                        ed.Amount > 0
                            ? ed.Amount + ed.Tax
                            : 0), 2);
            }
        }

        //2
        public double LastMonthRequireVND { get; set; }
        public double LastMonthRequireUSD { get; set; }
        //3 = 1 + 2
        public double LastMonthTotalVND
        {
            get { return Math.Round(LastMonthInvoiceNoTaxInvoiceVND + LastMonthRequireVND,0); }
        }

        public double LastMonthTotalUSD
        {
            get { return Math.Round(LastMonthInvoiceNoTaxInvoiceUSD + LastMonthRequireUSD,2); }
        }

        //4
        public double InMonthInvoiceVND
        {
            get { return Math.Round(ExportInMonths.Sum(ed => ed.AmountVnd),0); }
        }
        public double Tax
        {
            get { return Math.Round(ExportInMonths.Sum(ed => ed.Tax), 0); }
        }
        public double InMonthInvoiceUSD
        {
            get { return Math.Round(ExportInMonths.Sum(ed => ed.Amount),2); }
        }

        //5
        public double InMonthTaxInvoiceVND { get; set; }
        public double InMonthTaxInvoiceUSD { get; set; }
        // 6
        public double ReceiveInMonthVND { get; set; }
        public double ReceiveInMonthUSD { get; set; }
        //7
        public double InMonthReduceVND { get; set; }
        public double InMonthReduceUSD { get; set; }
        public double TotalExportQuantity
        {
            get { return ExportInMonths.Sum(ed => ed.Quantity); }
        }


        //8 = 1 + 4 - 5
        public double SumInvoiceNoTaxInvoiceVND
        {
            get { return Math.Round(LastMonthInvoiceNoTaxInvoiceVND + InMonthInvoiceVND +Tax- InMonthTaxInvoiceVND, 0); }
        }

        public double SumInvoiceNoTaxInvoiceUSD
        {
            get { return Math.Round(LastMonthInvoiceNoTaxInvoiceUSD + InMonthInvoiceUSD - InMonthTaxInvoiceUSD, 2); }
        }

        //9 = 2 + 5 - 6 - 7
        public double SumRequireVND
        {
            get { return Math.Round(LastMonthRequireVND + InMonthTaxInvoiceVND - ReceiveInMonthVND - InMonthReduceVND,0); }
        }

        public double SumRequireUSD
        {
            get { return Math.Round(LastMonthRequireUSD + InMonthTaxInvoiceUSD - ReceiveInMonthUSD - InMonthReduceUSD,2); }
        }

        //10 = 8 + 9
        public double SumTotalVND
        {
            get { return Math.Round(SumInvoiceNoTaxInvoiceVND + SumRequireVND,0); }
        }

        public double SumTotalUSD
        {
            get { return Math.Round(SumInvoiceNoTaxInvoiceUSD + SumRequireUSD,2); }
        }
        public bool Show
        {
            get
            {
                return LastMonthTotalVND + LastMonthTotalUSD + //3
                       InMonthInvoiceVND + InMonthInvoiceUSD + //4
                       InMonthTaxInvoiceVND + InMonthTaxInvoiceUSD + //5 
                       ReceiveInMonthVND + ReceiveInMonthUSD + //6
                       InMonthReduceVND + InMonthReduceUSD + //7
                       TotalExportQuantity > 0;
            }
        }
    }
}