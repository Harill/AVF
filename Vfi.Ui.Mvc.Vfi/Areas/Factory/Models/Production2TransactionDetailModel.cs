using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models
{
    public class Production2TransactionDetailModel
    {
        public long DetailId { get; set; }
        public long TransactionId { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public double Quantity { get; set; }
        public double QuantityDefect { get; set; }
        public double QuantityLost { get; set; }
        public double Time { get; set; }
        public double OverTime { get; set; }
        public double QuantityKg { get; set; }
        public string UnitMeasure { get; set; }
        public string Note { get; set; }

        public int? SectionIssueId { get; set; }
        public string SectionIssueName { get; set; }
        public double SectionIssueInv { get; set; }
        public double SectionIssueWeight { get; set; }

        public int? SectionReceiptId { get; set; }
        public string SectionReceiptName { get; set; }
        public double SectionReceiptInv { get; set; }
        public double SectionReceiptWeight { get; set; }

        public int SectionIndex { get; set; }
    }
}