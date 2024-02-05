using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class QcInvModel
    {
        public QcInvModel() {
            EarlyInventory = 0;
            LastInventory = 0;
            Weight = 0;

            ImportSx1 = 0;
            ImportCnc = 0;
            ImportSx2 = 0;
            ImportRb = 0;
            ImportNcu = 0;
            ImportCxl1 = 0;
            ImportQc = 0;
            TotalImport = 0;
            
            //get { return ImportSx1 + ImportCnc + ImportSx2 + ImportRb + ImportNcu + ImportCxl1 + ImportQc + ImportElse; }
            ExportCxl1 = 0;
            ExportQc = 0;
            ExportPacking = 0;
            TotalExport = 0;

            DiffImport = 0;
            DiffExport = 0;
        }
        public int GlobalIndex { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }

        public double Weight { get; set; }

        public double EarlyInventory { get; set; }

        public double EarlyInventoryKg
        {
            get { return Math.Round(EarlyInventory * Weight, 3); }
        }

        public double ImportSx1 { get; set; }
        public double ImportCnc { get; set; }
        public double ImportSx2 { get; set; }
        public double ImportRb { get; set; }
        public double ImportNcu { get; set; }
        public double ImportCxl1 { get; set; }
        public double ImportQc { get; set; }
        public double ImportInternal { get; set; }
        public double ImportElse {
            get {
                return TotalImport 
                    - ImportSx1 - ImportCnc - ImportSx2 
                    - ImportRb - ImportNcu - ImportQc 
                    - ImportCxl1 - ImportInternal;
            }
        }

        public double TotalImport { get; set; }

        public double ExportCxl1 { get; set; }
        public double ExportQc { get; set; }
        public double ExportSx2 { get; set; }
        public double ExportGcn { get; set; }
        public double ExportDefect { get; set; }
        public double ExportPacking { get; set; }
        public double ExportFinish { get; set; }
        public double ExportInternal { get; set; }
        public double ExportElse {
            get {
                return TotalExport
                    - ExportSx2 - ExportGcn
                    - ExportPacking - ExportFinish
                    - ExportCxl1 - ExportQc 
                    - ExportDefect - ExportInternal;
            }
        }

        public double TotalExport { get; set; }

        public double LastInventory { get; set; }

        public double LastInventoryKg
        {
            get { return Math.Round(LastInventory * Weight, 3); }
        }

        public bool Show {
            get {
                return EarlyInventory +
                       TotalImport + TotalExport +
                       LastInventory +
                        DiffQuantity + DiffImport + DiffExport != 0;
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
