
using System;
using System.ComponentModel;
using Vfi.Server.Core.DataModel.Models.Inv;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class MaterialInventoryPeriodModel: MaterialInventoryPeriodDomainModel
    {
        [DisplayName("Nhập")]
        public double? QtyImport { get; set; }

        [DisplayName("Xuất")]
        public double? QtyExport { get; set; }

        [DisplayName("Nhập Cây")]
        public double? QtyImportKg { get; set; }

        [DisplayName("Xuất Kg")]
        public double? QtyExportKg { get; set; }

        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public string HowStupidIam { get; set; }
        public string ToDateString { get; set; }

        public int MaterialForecasts { get; set; }

        public double AvgMaterialRequired { get; set; } 
    }
}