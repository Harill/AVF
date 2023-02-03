using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models {
    public class HeatTreatmentInvModel {
        public int GlobalIndex { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }

        public double Weight { get; set; }

        public double EarlyInventory { get; set; }
        public double EarlyInventoryKg { get { return EarlyInventory * Weight; } }
        public double ImportSx1 { get; set; }
        public double ImportSx2 { get; set; }
        public double ImportElse { get { return TotalImport - ImportSx1 - ImportSx2; } }
        public double TotalImport { get; set; }

        public double ExportGcn { get; set; }
        public double ExportRb { get; set; }
        public double ExportQc { get; set; }
        public double ExportElse { get { return TotalExport - ExportGcn - ExportRb - ExportQc; } }
        public double TotalExport { get; set; }

        public double LastInventory { get; set; }
        public double LastInventoryKg { get { return LastInventory * Weight; } }

        public bool Show {
            get {
                return EarlyInventory != 0 ||
                       TotalImport != 0 || TotalExport != 0 ||
                       LastInventory != 0 ||
                        DiffQuantity != 0 || DiffImport != 0 || DiffExport != 0;
            }
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
    }
}