using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Areas.Factory.Models;
using Vfi.Ui.Mvc.Vfi.Areas.Sales.Models;
using Vfi.Ui.Mvc.Vfi.Utilities;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models {
    public class ProductionTestingDailyModel {
        public ProductionTestingDailyModel() {
            Details = new List<ProductionTestingReportDetailModel>();
            Employees = new List<EmployeeTestingModel>();
            EmployeeIds = new List<int>();
        }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public int MachineId { get; set; }
        public string MachineName { get; set; }
        public string DisplayName { get { return MachineName + " -- " + ProductCode; } }
        public int WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public int FromWarehouseId { get; set; }
        public string FromWarehouseName { get; set; }
        public int ReferenceTestingDetailId { get; set; }
        public string TestCode { get; set; }
        public string TestName { get; set; }
        public string MachineTypeName { get; set; }
        public double TestRate { get; set; }

        public List<ProductionTestingReportDetailModel> Details { get; set; }
        public List<EmployeeTestingModel> Employees { get; set; }
        public List<int> EmployeeIds { get; set; }
        public string ProductionDate { get; set; }
        public string CustomerCode { get; set; }
        public string ShiftName { get; set; }
        public string ProductionTestingNote { get; set; }

        public string FromDateTimeStr { get; set; }
        public string ToDateTimeStr { get; set; }
    }

    public class ProductionTestingReportDetailModel {
        public DateTime Date { get; set; }
        public int Hour { get; set; }
        public string EmployeeCode { get; set; }
        public double Number { get; set; }
        public double MinNumber { get; set; }
        public double MaxNumber { get; set; }
        public int Valid { get { return (Number < MinNumber || Number > MaxNumber) ? 1 : 0; } }
    }

    public class EmployeeTestingModel {
        public int FromWarehouseId { get; set; }
        public string FromWarehouseName { get; set; }
        public int Idx { get; set; }
        public int Hour { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
    }

    public class GroupProductionTestingDailyModel {
        public GroupProductionTestingDailyModel() {
            List = new List<ProductionTestingDailyModel>();
            Details = new List<ProductionTestingReportDetailModel>();
            Employees = new List<EmployeeModel>();
            Notes = new List<ProductionTestingNoteModel>();
        }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public int MachineId { get; set; }
        public string MachineName { get; set; }
        public string TestCode { get; set; }
        public string TestName { get; set; }
        public double TestRate { get; set; }
        public string MachineTypeName { get; set; }
        public string ProductionDate { get; set; }
        public string CustomerCode { get; set; }
        public string ShiftName { get; set; }
        public string ProductionTestingNote { get; set; }
        public List<ProductionTestingDailyModel> List { get; set; }
        public List<ProductionTestingNoteModel> Notes { get; set; }
        public List<ProductionTestingReportDetailModel> Details { get; set; }
        public List<EmployeeModel> Employees { get; set; }
    }
}