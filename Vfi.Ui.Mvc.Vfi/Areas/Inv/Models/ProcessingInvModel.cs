using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models {
    public class ProcessingInvModel {
        public ProcessingInvModel() {
            Weight = 0;
        }
        public int GlobalIndex { get; set; }
        public int ProductInvId { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public string LotNumber { get; set; }
        public double Weight { get; set; }
        public int ErrorId { get; set; }
        public string ErrorDescription { get; set; }
        public string ImportDate { get; set; }
        public double EarlyQuantity { get; set; }
        public double ImportProduction1 { get; set; }
        public double ImportProduction2 { get; set; }
        public double ImportQc { get; set; }
        public double ImportElse { get; set; }
        public double TotalImport { get; set; }
        public double ExportReProcess { get; set; }
        public double ExportDefect { get; set; }
        public double TotalExport { get; set; }
        public double LastQuantity { get; set; }

        public int WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public double ReprocessingInv { get; set; }
        public string StoreCode { get; set; }

        public int DefectId { get; set; }
        public string DefectName { get; set; }

        public bool Show {
            get {
                return EarlyQuantity != 0 ||
                       TotalImport != 0 || TotalExport != 0 ||
                       LastQuantity != 0;
            }
        }
    }

    public class ProcessingDetail {

    }
}