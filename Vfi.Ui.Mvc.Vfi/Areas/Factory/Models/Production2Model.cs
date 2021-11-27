using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models
{
    public class Production2Model
    {
        public long TransactionDetailId { get; set; }
        public int GlobalIndex { get; set; }
        public int ProductId { get; set; }
        public int ProductionPrice { get; set; }
        public double ProductionCost { get { return ProductionPrice * Quantity; } }

        [DataType("_Production2CodeEditTemplate")]
        public string ProductCode { get; set; }

        public int ProductionSectionId { get; set; }

        [DataType("_SectionEditTemplate")]
        public string SectionName { get; set; }
        public int SectionIndex { get; set; }

        public double Production2Inventory { get; set; }
        public double TotalInventory { get; set; }

        [DataType("Number3")]
        public double Quantity { get; set; }

        public double QuantityPcs
        {
            get { return Weight > 0 ? Quantity/Weight*1000 : 0; }
        }

        [DataType("Number3")]
        public double QuantityDefect { get; set; }

        [DataType("Number3")]
        public double QuantityLost { get; set; }

        public string Unit { get; set; }

        public string Note { get; set; }
        public int SectionInvId { get; set; }
        public int SectionNext { get; set; }
        [DataType("_SectionEditNextTemplate")]
        public string SectionNextName { get; set; }
        public int SectionNextIndex { get; set; }


        public int MachineId { get; set; }

        [UIHint("_MachineEditTemplate")]
        public string MachineName { get; set; }

        public int EmployeeId { get; set; }

        [UIHint("_EmployeeEditTemplate")]
        public string EmployeeName { get; set; }
        public string Type { get; set; }
        public double Weight { get; set; }

        [DataType("Number1Digit")]
        public double Time { get; set; }

        public double DifferenceTime
        {
            get { return NumberToPeriod-Time; }
        }

        public double DifferenceNumber
        {
            get { return Time > 0 ? (Time * SectionProductivityKgInHour) - (Quantity + QuantityDefect) : 0; }
        }

        [DataType("Number1Digit")]
        public double OverTime { get; set; }

        public int PeriodId { get; set; }
        public DateTime PeriodDate { get; set; }
        public double SectionProductivity { get; set; }
        public bool IsAdd { get; set; }
        public bool IsProductionManager{get;set;}
        //pc/h
        public double SectionProductivityInHour
        {
            get { return SectionProductivity == 0 ? 0 : Math.Round(3600 / SectionProductivity, 0); }
        }

        public double SectionProductivityKgInHour
        {
            get { return Math.Round(SectionProductivityInHour * Weight / 1000, 3); }
        }
        public double NumberToPeriod
        {
            get
            {
                return SectionProductivityKgInHour > 0
                           ? Math.Round((Quantity + QuantityDefect)/SectionProductivityKgInHour, 1)
                           : 0;
            }
        }
        //x3600x5.8
        public double Value
        {
            get
            {
                return NumberToPeriod*20880;
            }
        }
    }
}