using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models {
    public class ImportExportProductionDetailModel {
        public ImportExportProductionDetailModel() {
            ExportInMonth = new double[31] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public DateTime ReportDate { get; set; }
        public string ProductCustomerCode { get; set; }
        public string ProductCode { get; set; }
        public string ProductCustomerName { get; set; }
        public double ProductPrice { get; set; }
        public double DesignProductivity { get; set; }
        public double ProductivityInMonth { get; set; }

        public double EarlyQuantity { get; set; }

        public double EarlyPrice {
            get { return EarlyQuantity * ProductPrice; }
        }

        public double ImportWeight { get; set; }
        public double ImportQuantity { get; set; }
        public double ImportMore { get; set; }
        public double ImportPurchase { get; set; }
        public double ImportInternal { get; set; }
        public double ImportReturn { get; set; }
        public double ImportPrice {
            get { return (ImportQuantity + ImportPurchase) * ProductPrice; }
        }
        public double TotalImport { get { return ImportQuantity + ImportReturn + ImportMore + ImportPurchase + ImportInternal + DiffImport; } }
        public double TotalImportPrice {
            get { return TotalImport * ProductPrice; }
        }

        public double ExportQuantity { get; set; }
        public double ExportPrice {
            get { return ExportQuantity * ProductPrice; }
        }

        public double ExportWeight { get; set; }
        public double ExportInternal { get; set; }
        public double ExportDestroy { get; set; }
        public double ExportDefect { get; set; }

        public double TotalExport { get { return ExportQuantity + ExportDestroy + ExportDefect + ExportInternal + DiffExport; } }
        public double TotalExportPrice {
            get { return TotalExport * ProductPrice; }
        }

        public double LastQuantity { get; set; }

        public double LastPrice {
            get { return LastQuantity * ProductPrice; }
        }
        public double DifferenceQuantity { get; set; }
        //public bool Show { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public double[] ExportInMonth { get; set; }
        public double Export { get { return ExportInMonth.Sum(); } }
        public double TranferInv { get; set; }

        public string MaterialType { get; set; }
        public string MaterialCode { get; set; }
        public double ProductionWeight { get; set; }
        public double MaterialPrice { get; set; }
        public double Transfer { get; set; }
        public double ImportTransfer { get; set; }
        public double ExportTransfer { get; set; }
        public DateTime? LastExportDate { get; set; }

        public double DiffQuantity {
            get {
                return EarlyQuantity 
                    + TotalImport + ImportTransfer
                    - TotalExport - ExportTransfer
                    - LastQuantity;
            }
        }
        /// <summary>
        /// re check import
        /// </summary>
        public double DiffImport { get; set; }
        /// <summary>
        /// re check export
        /// </summary>
        public double DiffExport { get; set; }

        public bool Show {
            get {
                return EarlyQuantity != 0 ||
                       TotalImport != 0 || TotalExport != 0 ||
                       LastQuantity != 0 ||
                        DiffQuantity != 0 || DiffImport != 0 || DiffExport != 0;
            }
        }
    }
    public class ImportExportProductionModel {
        public ImportExportProductionModel() {
            Details = new List<ImportExportProductionDetailModel>();
        }
        public string CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string CustomerCodeName { get; set; }
        public string Exchange { get; set; }
        public DateTime ReportDate { get; set; }

        public double EarlyQuantity {
            get { return Details.Sum(d => d.EarlyQuantity); }
        }
        public double EarlyPrice {
            get { return Details.Sum(d => d.EarlyPrice); }
        }
        //
        public double ImportQuantity {
            get { return Details.Sum(d => d.ImportQuantity); }
        }
        public double ImportPurchase {
            get { return Details.Sum(d => d.ImportPurchase); }
        }
        public double ImportMore {
            get { return Details.Sum(d => d.ImportMore); }
        }
        public double ImportInternal {
            get { return Details.Sum(d => d.ImportInternal); }
        }
        public double ImportReturn {
            get { return Details.Sum(d => d.ImportReturn); }
        }
        public double ImportPrice {
            get { return Details.Sum(d => d.ImportPrice); }
        }
        public double TotalImport {
            get { return Details.Sum(d => d.TotalImport); }
        }
        public double TotalImportPrice {
            get { return Details.Sum(d => d.TotalImportPrice); }
        }
        //
        public double ExportQuantity {
            get { return Details.Sum(d => d.ExportQuantity); }
        }
        public double ExportPrice {
            get { return Details.Sum(d => d.ExportPrice); }
        }
        public double ExportDestroy {
            get { return Details.Sum(d => d.ExportDestroy); }
        }
        public double ExportInternal {
            get { return Details.Sum(d => d.ExportInternal); }
        }
        public double ExportDefect {
            get { return Details.Sum(d => d.ExportDefect); }
        }
        public double TotalExport {
            get { return Details.Where(d => d.TotalExport > 0).Sum(d => d.TotalExport); }
        }
        public double TotalExportPrice {
            get { return Details.Where(d => d.TotalExportPrice > 0).Sum(d => d.TotalExportPrice); }
        }
        //
        public double LastQuantity {
            get { return Details.Sum(d => d.LastQuantity); }
        }
        public double LastPrice {
            get { return Details.Sum(d => d.LastPrice); }
        }


        public double Transfer {
            get { return Details.Sum(d => d.Transfer); }
        }
        public double ImportTransfer {
            get { return Details.Sum(d => d.ImportTransfer); }
        }
        public double ExportTransfer {
            get { return Details.Sum(d => d.ExportTransfer); }
        }

        public double DiffImport { get { return Details.Sum(d => d.DiffImport); } }

        public double DiffExport { get { return Details.Sum(d => d.DiffExport); } }

        public double DifferenceQuantity {
            get { return Details.Sum(d => d.DifferenceQuantity); }
        }
        public List<ImportExportProductionDetailModel> Details { get; set; }

    }
}