using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class WorkpieceImportExportModel
    {
        public string TransactionCode { get; set; }
        public long TransactionId { get; set; }
        public string WarehouseName { get; set; }
        public string ImportExport { get; set; }
        public int EoIId { get; set; }
        public long PeriodId { get; set; }
        public DateTime Date { get; set; }
        public double Weight { get; set; }
    }
}