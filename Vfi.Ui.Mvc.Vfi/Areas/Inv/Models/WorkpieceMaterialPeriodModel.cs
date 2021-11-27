using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;
using Vfi.Ui.Mvc.Vfi.Models.Production;
using Vfi.Ui.Mvc.Vfi.Utilities;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class WorkpieceMaterialPeriodModel
    {
        public WorkpieceMaterialPeriodModel()
        {
            Type = 0;
            AvgMaterialUnitPrice = 0;
            EarlyQuantity = 0;
            LastQuantity = 0;

            Import = 0;
            ImportVirtual = 0;

            Export = 0;
            Destroy = 0;
            Process = 0;
        }
        public DateTime ReportDate { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }

        public long PeriodId { get; set; }
        public string IdentityCode { get; set; }
        public string MaterialTypeName { get; set; }
        public int Type { get; set; }
        public string TypeName { get { return MyUtilities.Material.GetMaterialIdentityTypeName(Type); } }
        [DataType("NumberAll2")]
        public double Weight { get; set; }
        public string Note { get; set; }
        public int EoIId { get; set; }
        public int EoI { get; set; }
        public int AvgMaterialUnitPrice { get; set; }
        public double TotalQuantity { get; set; }
        public double EarlyQuantity { get; set; }
        public double EarlyPrice { get { return EarlyQuantity * AvgMaterialUnitPrice; } }

        public double LastQuantity { get; set; }
        public double LastPrice { get { return LastQuantity * AvgMaterialUnitPrice; } }


        public double Import { get; set; }
        public double ImportVirtual { get; set; }
        public double TotalImport { get { return Import + ImportVirtual; } }
        public double TotalImportPrice { get { return TotalImport * AvgMaterialUnitPrice; } }

        public double Export { get; set; }
        public double Destroy { get; set; }
        public double Process { get; set; }
        public double TotalExport { get { return Export + Destroy + Process; } }
        public double TotalExportPrice { get { return TotalExport * AvgMaterialUnitPrice; } }

        public bool Border { get; set; }
        public bool IsDestroy { get; set; }
        public bool IsProcess { get; set; }

        public double LastQuantityCheck
        {
            get { return EarlyQuantity + TotalImport - TotalExport - LastQuantity; }
        }
    }
}