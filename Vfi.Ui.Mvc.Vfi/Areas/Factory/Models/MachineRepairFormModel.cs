using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;
using Vfi.Ui.Mvc.Vfi.Utilities;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models
{
    public class MachineRepairFormModel
    {
        public MachineRepairFormModel()
        {
            Timing = 0;
            Productivity = 0;
            ProductPrice = 0;
            MoreTime = 0;
            FromDate = new DateTime();
            ToDate = new DateTime();
            Details = new List<RepairFormDetailModel>();
            EstimateTime = 0;
        }

        public List<RepairFormDetailModel> Details { get; set; }

        public string Time { get; set; }
        public string Title { get; set; }
        
        public int Index { get; set; }
        public int FormId { get; set; }
        public int MachineId { get; set; }

        [UIHint("_MachineProductionEditTemplate")]
        public string MachineName { get; set; }

        [UIHint("_MachineProduction2EditTemplate")]
        public string MachineName2 { get; set; }

        public int ProductId { get; set; }

        [UIHint("_ProductCodeNameTemplate")]
        public string ProductCode { get; set; }

        [UIHint("_Production2CodeEditTemplate")]
        public string ProductCode2 { get; set; }

        [UIHint("_MachineStateTemplate")]
        public string StateName { get; set; }
        public string StateCode { get; set; }

        public int EstimateTime { get; set; }
        public bool BetweenTime {
            get {
                return EstimateTime > 30 && EstimateTime < 120 ? true : false;
            }
        }
        
        public int StateId { get; set; }
        public int ErrorCauseId { get; set; }
        [UIHint("_MachineErrorTemplate")]
        public string ErrorCause { get; set; }
        public int FixId { get; set; }

        [UIHint("_MachineStateDetailTemplate")]
        public string HowToFix { get; set; }

        public DateTime CreateDate { get; set; }

        [UIHint("_EmployeeQcLineTemplate")]
        public string CreateUser { get; set; }
        [UIHint("_DateTimeTemplateNullable")]
        public DateTime? CauseDate { get; set; }
        public int EmployeeId { get; set; }

        [UIHint("_EmployeeRepairNameTemplate")]
        public string EmployeeName { get; set; }

        [UIHint("_Employee2EditTemplate")]
        public string EmployeeName2 { get; set; }

        public int CreateUserId { get; set; }

        [UIHint("_DateTimeTemplateNullable")]
        public DateTime? StartDate { get; set; }

        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        [UIHint("NumberAsInt")]
        public int ErrorQuantity { get; set; }

        public int CountDay
        {
            get { return  (ToDate - FromDate).Days + 1; }
        }

        public int Color
        {
            get
            {
                if (Status == (byte)MyUtilities.Machine.State.RepairStatus.UnFinish) return 1; // không đạt
                if (StateId == MyUtilities.Machine.State.Setup) return 2; // lên máy
                if (StateId == MyUtilities.Machine.State.Done) return 3; // bảo trì
                return 0; // bình thường
            }
        }

        public int SectionId { get; set; }

        [UIHint("_SectionEditTemplate")]
        public string SectionName { get; set; }

        public int SectionIndex { get; set; }

        public string StartDateString
        {
            get
            {
                return StartDate != null
                           ? FinishDate != null
                                 ? (StartDate.Value.ToString("dd/MM")
                                             .Equals(FinishDate.Value.ToString("dd/MM")) &&
                                    StartDate.Value.ToString("dd/MM").Equals(ToDate.ToString("dd/MM")))
                                       ? StartDate.Value.ToString("HH:mm")
                                       : StartDate.Value.ToString("dd/MM HH:mm")
                                 : StartDate.Value.ToString("dd/MM HH:mm")
                           : "";
            }
        }

        public string StartUser { get; set; }
        public int Status { get; set; }

        [UIHint("_MachineRepairStatusEditTemplate")]
        public string StatusName { get; set; }

        [UIHint("_DateTimeTemplateNullable")]
        public DateTime? FinishDate { get; set; }

        public string FinishDateString
        {
            get
            {
                return (FinishDate != null && StartDate != null)
                           ? (StartDate.Value.ToString("dd/MM")
                                       .Equals(FinishDate.Value.ToString("dd/MM")) &&
                              StartDate.Value.ToString("dd/MM").Equals(ToDate.ToString("dd/MM")))
                                 ? FinishDate.Value.ToString("HH:mm")
                                 : FinishDate.Value.ToString("dd/MM HH:mm")
                           : "";
            }
        }

        public string FinishUser { get; set; }
        public int Timing { get; set; }
        public int Shift { get; set; }
        public int MoreTime { get; set; }

        public int DetailCount { get; set; }

        public int FixTime
        {
            get
            {
                if (Details.Any())
                    return Details.Sum(d => d.FixTime);
                return (FinishDate != null && StartDate != null)
                           ? Convert.ToInt32((FinishDate - StartDate).Value.TotalMinutes)
                           : 0;
            }
        }

        public string FixTimeString
        {
            get
            {
                if (Details.Any())
                    return string.Format("{0:n0}",Details.Sum(d => d.FixTime));
                return (FinishDate != null && StartDate != null)
                           ? string.Format(Convert.ToInt32((FinishDate - StartDate).Value.TotalMinutes) + "", "{0:n0}")
                           : "";
            }
        }

        public int DiffTime
        {
            get
            {
                if (Details.Any())
                    return Details.Sum(d => d.DiffTime);
                return
                    (FinishDate != null && StartDate != null)
                        ? Status == (byte) MyUtilities.Machine.State.RepairStatus.Finish
                              ? Convert.ToInt32((FinishDate - StartDate).Value.TotalMinutes) - Timing - MoreTime > 0
                                    ? Convert.ToInt32((FinishDate - StartDate).Value.TotalMinutes) - Timing - MoreTime
                                    : 0
                              : Convert.ToInt32((FinishDate - StartDate).Value.TotalMinutes)
                        : 0;
            }
        }

        public double Productivity { get; set; }

        public double ProductivityInMinute
        {
            get
            {
                return (Productivity > 0)
                           ? (60/Productivity)
                           : 0;
            }
        }

        public double DiffProductQuantity
        {
            get
            {
                if (Details.Any())
                    return Details.Sum(d => d.DiffProductQuantity);
                return Math.Round(ProductivityInMinute * DiffTime, 0);
            }
        }

        public double ProductPrice { get; set; }

        public double DiffPoint {
            get {
                if (Details.Any())
                    return Details.Sum(d => d.DiffPoint);
                return
                    Math.Round(
                    (ProductPrice * MyUtilities.Monitor.GetParameterValue(MyUtilities.Monitor.BaseProductionPriceRate)
                    * DiffProductQuantity)
                    / 1000000
                    , 3);
            }
        }

        public double DiffValue
        {
            get
            {
                if (Details.Any())
                    return Details.Sum(d => d.DiffValue); 
                return DiffPoint * MyUtilities.Product.PointValue;
            }
        }

        public string Note { get; set; }

        public string GetUpdateStateLog()
        {
            string a = "Lỗi: ";
            if (!string.IsNullOrWhiteSpace(ErrorCause))
                a += "| Nguyên nhân: " + ErrorCause;
            if (FinishDate != null)
            {
                a += "| Khắc phục: " + HowToFix;
                a += "| Thời gian sửa: " + FixTime;
                a += "| " + MyUtilities.Machine.State.GetRepairStatusText(Status);
            }
            return a;
        }
    }
    public class JobAssignmentGroup {
        public JobAssignmentGroup() {
            Details = new List<MachineRepairFormModelByEmployee>();
        }

        public string GroupName { get; set; }

        public int Count {
            get { return Details.Sum(d => d.Count); }
        }

        public int FixTime {
            get { return Details.Sum(d => d.FixTime); }
        }

        public string ReportDate { get; set; }

        public List<MachineRepairFormModelByEmployee> Details { get; set; }
    }

    public class MachineRepairFormModelByEmployee
    {
        public MachineRepairFormModelByEmployee()
        {
            Details = new List<MachineRepairFormModel>();
        }
        public int Index { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string GroupName { get; set; }
        public int Count { get { return Details.Count; } }
        public int FixTime
        {
            get { return Details.Sum(d => d.FixTime); }
        }

        public int DiffTime
        {
            get { return Details.Sum(d => d.DiffTime); }
        }

        public double DiffPoint
        {
            get { return Details.Sum(d => d.DiffPoint); }
        }
        public int CountDay { get; set; }
        public int MaxFixTime { get { return CountDay*450; } }
        public List<MachineRepairFormModel> Details { get; set; }
    }
    public class MachineRepairFormModelByShift
    {
        public MachineRepairFormModelByShift()
        {
            List = new List<MachineRepairFormModelByEmployee>();
            CountType = new List<CountMachineRepairType>();
        }
        public int Index { get; set; }
        public string Shift { get; set; }
        public string ReportDateString { get; set; }
        public string FromDateString { get; set; }
        public string ToDateString { get; set; }
        public int Count { get { return List.Count; } }
        public int TotalCount { get { return List.Sum(l => l.Details.Count); } }
        public int FixTime
        {
            get { return List.Sum(d => d.FixTime); }
        }

        public int DiffTime
        {
            get { return List.Sum(d => d.DiffTime); }
        }

        public double DiffPoint
        {
            get { return List.Sum(d => d.DiffPoint); }
        }
        public List<MachineRepairFormModelByEmployee> List { get; set; }
        public List<CountMachineRepairType> CountType { get; set; }
    }
    public class CountMachineRepairType
    {
        public string NameType { get; set; }
        public int Color { get; set; }
        public int CountType { get; set; }
        public int TotalTime { get; set; }
        public int TotalDiffTime { get; set; }
    }
}