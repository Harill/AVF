using System;
using System.ComponentModel.DataAnnotations;

namespace Vfi.Ui.Mvc.Vfi.Areas.Purchasing.Models
{
    public class PlatingFormModel
    {
        public int FormId { get; set; }
        public int VendorId { get; set; }
        public string VendorCode { get; set; }
        public string VendorName { get; set; }
        public string PlatingFormNumber { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public byte Status { get; set; }
        public int PlatingType { get; set; }
        [UIHint("_PlatingTypeEditTemplate")]
        public string PlatingTypeName { get; set; }
        [UIHint("_PlatingStatusEditTemplate")]
        public string StatusName { get; set; }
        [UIHint("_CurrencyEditTemplate")]
        public string CurrencyCode { get; set; }
        public string CurrencyCodeName { get; set; }
        public int ExchangeRate { get; set; }
        public string Note { get; set; }
        public double TotalQuantityRequirement { get; set; }
        public double TotalImport { get; set; }
        public double TotalImportPrice { get; set; }
        public double TotalExport { get; set; }
        public double TotalExportPrice { get; set; }
        public double TotalPrice { get; set; }
        public string TotalPriceString { get; set; }
        public string VendorCodeName
        {
            get { return VendorCode + "--" + VendorName; }
            set { VendorCode = value; }
        }

        public bool IsPurchasingManager { get; set; }

    }
}