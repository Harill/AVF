using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models {
    public class Production2InvModel {
        public Production2InvModel() {
            EarlyInventory = 0;
            LastInventory = 0;
            Weight = 0;

            ImportSx1 = 0;
            ImportSx2 = 0;
            ImportCnc = 0;
            ImportCxl1 = 0;
            //ImportElse = 0;

            ExportQcA = 0;
            ExportCxl1 = 0;
            ExportGcn = 0;
            ExportRb = 0;
            ExportSx2 = 0;
            //ExportElse = 0;
            ExportDefect = 0;
            DiffImport = 0;
            DiffExport = 0;
        }
        public string Name { get; set; }
        public DateTime ReportDate { get; set; }
        public int GlobalIndex { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }

        public double Weight { get; set; }

        public double EarlyInventory { get; set; }
        public double EarlyInventoryKg {
            get { return Math.Round(EarlyInventory * Weight, 3); }
        }
        public double ImportSx1 { get; set; }
        public double ImportSx2 { get; set; }
        public double ImportCnc { get; set; }
        public double ImportCxl1 { get; set; }
        public double ImportElse { get { return TotalImport - ImportSx1 - ImportSx2 - ImportCnc - ImportCxl1; } }
        public double TotalImport { get; set; }
        public double TotalImportKg {
            get { return Math.Round(TotalImport * Weight, 3); }
        }

        public double ExportSx2 { get; set; }
        public double ExportCnc { get; set; }
        public double ExportNl { get; set; }
        public double ExportRb { get; set; }
        public double ExportGcn { get; set; }
        public double ExportQcA { get; set; }
        public double ExportCxl1 { get; set; }
        public double ExportDefect { get; set; }
        public double ExportElse {
            get {
                return TotalExport - ExportSx2 - ExportCnc - ExportNl - ExportRb - ExportGcn - ExportQcA - ExportCxl1 - ExportDefect;
            }
        }

        public double TotalExport { get; set; }
        public double TotalExportKg {
            get { return Math.Round(TotalExport * Weight, 3); }
        }
        public double LastInventory { get; set; }
        public double LastInventoryKg {
            get { return Math.Round(LastInventory * Weight, 3); }
        }
        public double DiffQuantity {
            get {
                return EarlyInventory + TotalImport - TotalExport - LastInventory;
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
        public string Note { get; set; }

        public bool Show { get; set; }
    }
}