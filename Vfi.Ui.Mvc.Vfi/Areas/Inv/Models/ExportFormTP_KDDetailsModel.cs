using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class ExportFormTP_KDDetailsModel
    {
        public int Id { get; set; }
        public int ExportFormId { get; set; }
        public long DetailId { get; set; }
        public int ProductId { get; set; }

        [DataType("Number")]
        public double Quality { get; set; }

        [DataType("Number")]
        public double Weight { get; set; }

        public int BigBox { get; set; }
        public int SmallBox { get; set; }
        public string Note { get; set; }

        [UIHint("_ProductEditTemplate")]
        public string ProductCode { get; set; }

        public int ProductInvId { get; set; }

        [UIHint("_ProductCodeInvEditTemplate")]
        public string ProductInvCode { get; set; }

        public double TotalQuantity { get; set; }
        public int RequiredNumber { get; set; }

        public double SentNumber { get; set; }
        public double SentWeight { get; set; }
        public string StatusInvoice { get; set; }
        public bool IsInvoiced { get; set; }
        public double ProductWeight { get; set; }
        public long TransactionDetailId { get; set; }
        public string TransactionCode { get; set; }
        public DateTime ExportDate { get; set; }
        public string LotNumber { get; set; }
    }
}