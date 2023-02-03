using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class CncInvModel
    {
        public int GlobalIndex { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string CustomerCode { get; set; }
        public double Weight { get; set; }
        public double EarlyInventory { get; set; }
        public double EarlyInventoryKg
        {
            get { return EarlyInventory*Weight/1000; }
        }

        public double LastInventory { get; set; }
        public double LastInventoryKg
        {
            get { return LastInventory * Weight/1000; }
        }

        public double ImportSx1 { get; set; }
        public double ImportSx2 { get; set; }
        public double ImportCxl1 { get; set; }
        public double ImportElse { get { return TotalImport - ImportSx1 - ImportSx2 - ImportCxl1; } }
        public double TotalImport { get; set; }

        public double ExportSx2 { get; set; }
        public double ExportQcA { get; set; }
        public double ExportCxl1 { get; set; }
        public double ExportPp { get; set; }
        public double ExportElse { get { return TotalExport - ExportSx2 - ExportQcA - ExportCxl1 - ExportPp; } }

        public double TotalExport { get; set; }

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