using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models {
    public class PackingInvModel {
        public PackingInvModel() {
            EarlyInventory = 0;
            LastInventory = 0;
            Weight = 0;
            ImportQc = 0;
            ExportFinish = 0;
        }
        public int GlobalIndex { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public string LotNumber { get; set; }

        public double Weight { get; set; }

        public double EarlyInventory { get; set; }
        public double EarlyInventoryKg {
            get {
                return Math.Round(EarlyInventory * Weight, 2);
            }
        }

        public double ImportQc { get; set; }
        public double ImportElse { get { return TotalImport - ImportQc; } }
        public double TotalImport { get; set; }

        public double ExportFinish { get; set; }
        public double ExportQc { get; set; }
        public double ExportCxl1 { get; set; }
        public double ExportElse { get { return TotalExport - ExportQc - ExportCxl1 - ExportFinish; } }
        public double TotalExport { get; set; }


        public double LastInventory { get; set; }
        public double LastInventoryKg {
            get {
                return Math.Round(LastInventory * Weight, 2);
            }
        }

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
        public double DiffImport { get; set; }
        public double DiffExport { get; set; }
    }
}