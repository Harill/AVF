using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models {

    public class DefectGroupReportModel {
        public DefectGroupReportModel() {
            Details = new List<DefectReportModel>();
        }
        public string GroupName { get; set; }
        public DateTime ReportDate { get; set; }
        public int Shift { get; set; }
        public string ReportDateStr { get; set; }

        public List<DefectReportModel> Details { get; set; }
        public double Quantity {
            get {
                return Details.Sum(x => x.Quantity);
            }
        }
    }

    public class DefectReportModel {
        public int ProductId { get; set; }
        public string ProductCode { get; set; }

        public int MachineId { get; set; }
        public string MachineName { get; set; }

        public int DefectId { get; set; }
        public string DefectName { get; set; }

        public int RemedyId { get; set; }
        public string RemedyName { get; set; }

        public int NextWarehouseProcessId { get; set; }
        public string NextWarehouseProcessName { get; set; }

        public bool IsDetroy { get; set; }
        public string DetroySymbol {
            get {
                return IsDetroy ? "✓" : "";
            }
        }

        public double Quantity { get; set; }

        public string IssueWarehouseName { get; set; }
        public string TransactionCode { get; set; }
        public string ReportDateStr { get; set; }
        public int Shift { get; set; }
        public string GroupName { get; set; }

    }
}