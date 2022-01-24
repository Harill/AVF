using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;
using Vfi.Ui.Mvc.Vfi.Utilities;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models
{
    public class RepairFormDetailModel
    {
        public int DetailId { get; set; }
        public int FormId { get; set; }
        public int StateId { get; set; }
        public int EmployeeId { get; set; }
        [UIHint("_EmployeeRepairNameTemplate")]
        public string EmployeeName { get; set; }
        [UIHint("_DateTimeTemplateNullable")]
        public System.DateTime? StartDate { get; set; }
        public string StartUser { get; set; }
        public int Status { get; set; }
        [UIHint("_MachineRepairStatusEditTemplate")]
        public string StatusName { get; set; }
        [UIHint("_DateTimeTemplateNullable")]
        public DateTime? FinishDate { get; set; }
        public string FinishUser { get; set; }
        public Nullable<int> FixId { get; set; }
        [UIHint("_MachineStateDetailTemplate")]
        public string HowToFix { get; set; }
        public string Note { get; set; }
        public int Shift { get; set; }
        public int MoreTime { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        [UIHint("NumberAsInt")]
        public int FixQuantity { get; set; }
        public DateTime ToDate { get; set; }
        public string FinishDateString
        {
            get
            {
                return (FinishDate != null)
                           ? (StartDate.Value.ToString("dd//MM/yyyy")
                                       .Equals(FinishDate.Value.ToString("dd/MM/yyyy")) &&
                              StartDate.Value.ToString("dd//MM/yyyy").Equals(ToDate.ToString("dd/MM/yyyy")))
                                 ? FinishDate.Value.ToString("HH:mm")
                                 : FinishDate.Value.ToString("dd/MM/yyyy HH:mm")
                           : "";
            }
        }

        public string StartDateString
        {
            get
            {
                return StartDate != null
                           ? FinishDate != null
                                 ? (StartDate.Value.ToString("dd//MM/yyyy")
                                             .Equals(FinishDate.Value.ToString("dd/MM/yyyy")) &&
                                    StartDate.Value.ToString("dd//MM/yyyy").Equals(ToDate.ToString("dd/MM/yyyy")))
                                       ? StartDate.Value.ToString("HH:mm")
                                       : StartDate.Value.ToString("dd/MM/yyyy HH:mm")
                                 : StartDate.Value.ToString("dd/MM/yyyy HH:mm")
                           : "";
            }
        }
        public int FixTime
        {
            get
            {
                return (FinishDate != null && StartDate != null)
                           ? Convert.ToInt32((FinishDate - StartDate).Value.TotalMinutes)
                           : 0;
            }
        }

        public string FixTimeString
        {
            get
            {
                return (FinishDate != null && StartDate != null)
                           ? string.Format(Convert.ToInt32((FinishDate - StartDate).Value.TotalMinutes) + "", "{0:n0}")
                           : "";
            }
        }

        public int Timing { get; set; }
        public int DiffTime
        {
            get
            {
                if (StateId == MyUtilities.Machine.State.Done)
                    return 0;
                return
                    (FinishDate != null && StartDate != null)
                        ? Status == (byte)MyUtilities.Machine.State.RepairStatus.Finish
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
                           ? (60 / Productivity)
                           : 0;
            }
        }

        public double DiffProductQuantity
        {
            get { return Math.Round(ProductivityInMinute * DiffTime, 0); }
        }

        public double ProductPrice { get; set; }

        public double DiffPoint {
            get {
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
            get { return DiffPoint * MyUtilities.Product.PointValue; }
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
    }
}