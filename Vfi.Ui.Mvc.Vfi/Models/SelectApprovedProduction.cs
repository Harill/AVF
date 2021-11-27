using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class SelectApprovedProduction
    {
        public Nullable<int> MaterialInvId { get; set; }
        public double MaterialWeight { get; set; }
        public int MaterialId { get; set; }
        public int ProductionRate { get; set; }
        public Nullable<int> MachineId { get; set; }
        public string MachineName { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public double ProductWeight { get; set; }
        public System.DateTime ImportDate { get; set; }
        public System.DateTime MaterialUseDate { get; set; }
        public Nullable<double> MaterialUse { get; set; }
        public Nullable<double> Number { get; set; }
        public Nullable<double> Processing { get; set; }
        public Nullable<double> Defect { get; set; }
        public Nullable<double> ProductionDiff { get; set; }
    }
}
