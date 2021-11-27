using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models {
    public class Production2WaitingInvModel {
        public Production2WaitingInvModel() {
            EarlyInventory = 0;
            LastInventory = 0;
            Weight = 0;

            ImportSx1 = 0;
            ImportCnc = 0;
            ImportSx2Process = 0;
            ImportElse = 0;
            TotalImport = 0;

            ExportSx2B = 0;
            ExportSx2C = 0;
            ExportSx2D = 0;
            ExportCxl1 = 0;
            ExportElse = 0;
            TotalExport = 0;
        }

        public string Name { get; set; }
        public DateTime ReportDate { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }

        public double Weight { get; set; }

        public double EarlyInventory { get; set; }
        public double EarlyInventoryWeight {
            get { return Math.Round(EarlyInventory * Weight, 3); }
        }
        public double ImportSx1 { get; set; }
        public double ImportCnc { get; set; }
        public double ImportSx2Process { get; set; }
        public double ImportElse { get; set; }
        public double TotalImport { get; set; }
        public double TotalImportWeight {
            get { return Math.Round(TotalImport * Weight, 3); }
        }

        public double ExportSx2B { get; set; }
        public double ExportSx2C { get; set; }
        public double ExportSx2D { get; set; }
        public double ExportCxl1 { get; set; }
        public double ExportElse { get; set; }

        public double TotalExport { get; set; }
        public double TotalExportWeight {
            get { return Math.Round(TotalExport * Weight, 3); }
        }

        public double LastInventory { get; set; }
        public double LastInventoryWeight {
            get { return Math.Round(LastInventory * Weight, 3); }
        }
        public double DiffQuantity {
            get {
                return EarlyInventory + TotalImport - TotalExport - LastInventory;
            }
        }


        public bool Show {
            get {
                return EarlyInventory +
                       TotalImport + TotalExport +
                       LastInventory +
                        DiffQuantity != 0;
            }
        }
    }
}