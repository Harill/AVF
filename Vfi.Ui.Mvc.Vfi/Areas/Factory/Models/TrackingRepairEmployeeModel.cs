using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models {
    public class TrackingRepairEmployeeModel {
        public int TrackingId { get; set; }
        public int MachineId { get; set; }
        [UIHint("_MachineEditTemplate")]
        public string MachineName { get; set; }
        public int RepairEmployeeId { get; set; }
        [UIHint("_EmployeeRepairNameTemplate")]
        public string RepairEmployeeName { get; set; }
        public int QcEmployeeId { get; set; }
        [UIHint("_EmployeeQcLineTemplate")]
        public string QcEmployeeName { get; set; }
        [UIHint("_DateTimeTemplateNullable")]
        public DateTime StartDate { get; set; }
        public int Status { get; set; }
        public string StatusName { get; set; }
        [UIHint("_DateTimeTemplateNullable")]
        public DateTime? FinishDate { get; set; }
        public int Shift { get; set; }
        [UIHint("NumberAsInt")]
        public int FixQuantity { get; set; }
        public int MoreTime { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public string Note { get; set; }

        public int FixTime {
            get {
                return (FinishDate != null)
                           ? Convert.ToInt32((FinishDate - StartDate).Value.TotalMinutes)
                           : 0;
            }
        }
    }
}