
using System;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models {
    public class InventoryCardModel {
        public InventoryCardModel() {
            InventoryStart = 0;
            Weight = 0;
            ImportProduction = 0;
            ImportVirtual = 0;

        }
        public int ProductId { get; set; }
        public int MaterialInvId { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public double Weight { get; set; }
        public double InventoryStart { get; set; }
        //public double InventoryStartKg { get { return InventoryStart*Weight; } }
        public double ImportProduction { get; set; }
        public double ProcessProduction { get; set; }
        public double ImportVirtual { get; set; }
        public double ImportInternal { get; set; }
        public double ProductionProcessing { get; set; }
        public double ProcessProcessing { get; set; }
        public double TotalProcessing { get { return ProductionProcessing + ProcessProcessing; } }
        public double SendBack { get; set; }
        public double TotalImport {
            get { return ImportProduction + ImportVirtual + ImportInternal + SendBack; }
        }
        public double ExportSell { get; set; }
        public double ExportDestroy { get; set; }
        public double ExportInternal { get; set; }
        public double ExportDefect { get; set; }
        public double ExportProcessing { get; set; }
        public double TotalExport {
            get { return ExportSell + ExportDestroy + ExportInternal + ExportProcessing + ExportDefect; }
        }

        public string UserModified { get; set; }
        public DateTime DateModified { get; set; }

        public bool Show {
            get {
                return TotalImport + Math.Abs(TotalExport) +
                       Order + Forecast +
                       ProcessProduction + ProcessCNC + ProcessProduction2 + TotalProcessing > 0;
            }
        }
        public double Order { get; set; }
        public double ProcessCNC { get; set; }
        public double ProcessProduction2 { get; set; }

        public double Forecast { get; set; }
        public string LotNumber { get; set; }
    }
}