using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class Machine
    {
        public Machine()
        {
            this.DefectTransactionDetails = new List<DefectTransactionDetail>();
            this.ExportMaterialDetails = new List<ExportMaterialDetail>();
            this.ExportToolDetails = new List<ExportToolDetail>();
            this.ImportFormCncDetails = new List<ImportFormCncDetail>();
            this.ImportFormSX1Detail = new List<ImportFormSX1Detail>();
            this.MachineAppraisals = new List<MachineAppraisal>();
            this.MachineLogs = new List<MachineLog>();
            this.MachineRepairForms = new List<MachineRepairForm>();
            this.MaterialInvOnMachines = new List<MaterialInvOnMachine>();
            this.MaterialInvOnMachinePeriods = new List<MaterialInvOnMachinePeriod>();
            this.MaterialUseDetails = new List<MaterialUseDetail>();
            this.MaterialUseDetails1 = new List<MaterialUseDetail>();
            this.ProductInventories = new List<ProductInventory>();
            this.Production2TransactionDetail = new List<Production2TransactionDetail>();
            this.ProductionHeatTreatments = new List<ProductionHeatTreatment>();
            this.ProductionPolishes = new List<ProductionPolish>();
            this.ProductionProcessByMachines = new List<ProductionProcessByMachine>();
            this.ProductionSections = new List<ProductionSection>();
            this.RealProductions = new List<RealProduction>();
            this.RealTestings = new List<RealTesting>();
            this.RealTestings1 = new List<RealTesting>();
            this.SmartProductions = new List<SmartProduction>();
            this.SmartProduction2 = new List<SmartProduction2>();
            this.ToolInvOnMachines = new List<ToolInvOnMachine>();
            this.TrackingRepairEmployees = new List<TrackingRepairEmployee>();
            this.TrackUpMachines = new List<TrackUpMachine>();
            this.TransactionDetails = new List<TransactionDetail>();
            this.WorkOrderRoutings = new List<WorkOrderRouting>();
        }

        public int MachineId { get; set; }
        public string MachineName { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public Nullable<int> StateId { get; set; }
        public Nullable<double> Number { get; set; }
        public Nullable<int> DayRate { get; set; }
        public Nullable<System.DateTime> StartProductionDate { get; set; }
        public string Note { get; set; }
        public Nullable<int> DiagramType { get; set; }
        public Nullable<int> ColumnIndex { get; set; }
        public Nullable<int> RowIndex { get; set; }
        public string ErrorCause { get; set; }
        public string HowToFix { get; set; }
        public Nullable<System.DateTime> ModifiedState { get; set; }
        public Nullable<System.DateTime> ModifiedFix { get; set; }
        public Nullable<int> ProcessingTypeId { get; set; }
        public bool Production2 { get; set; }
        public int MachineFunction { get; set; }
        public virtual ICollection<DefectTransactionDetail> DefectTransactionDetails { get; set; }
        public virtual ICollection<ExportMaterialDetail> ExportMaterialDetails { get; set; }
        public virtual ICollection<ExportToolDetail> ExportToolDetails { get; set; }
        public virtual ICollection<ImportFormCncDetail> ImportFormCncDetails { get; set; }
        public virtual ICollection<ImportFormSX1Detail> ImportFormSX1Detail { get; set; }
        public virtual MachineState MachineState { get; set; }
        public virtual ProcessingType ProcessingType { get; set; }
        public virtual ICollection<MachineAppraisal> MachineAppraisals { get; set; }
        public virtual ICollection<MachineLog> MachineLogs { get; set; }
        public virtual ICollection<MachineRepairForm> MachineRepairForms { get; set; }
        public virtual ICollection<MaterialInvOnMachine> MaterialInvOnMachines { get; set; }
        public virtual ICollection<MaterialInvOnMachinePeriod> MaterialInvOnMachinePeriods { get; set; }
        public virtual ICollection<MaterialUseDetail> MaterialUseDetails { get; set; }
        public virtual ICollection<MaterialUseDetail> MaterialUseDetails1 { get; set; }
        public virtual ICollection<ProductInventory> ProductInventories { get; set; }
        public virtual ICollection<Production2TransactionDetail> Production2TransactionDetail { get; set; }
        public virtual ICollection<ProductionHeatTreatment> ProductionHeatTreatments { get; set; }
        public virtual ICollection<ProductionPolish> ProductionPolishes { get; set; }
        public virtual ICollection<ProductionProcessByMachine> ProductionProcessByMachines { get; set; }
        public virtual ICollection<ProductionSection> ProductionSections { get; set; }
        public virtual ICollection<RealProduction> RealProductions { get; set; }
        public virtual ICollection<RealTesting> RealTestings { get; set; }
        public virtual ICollection<RealTesting> RealTestings1 { get; set; }
        public virtual ICollection<SmartProduction> SmartProductions { get; set; }
        public virtual ICollection<SmartProduction2> SmartProduction2 { get; set; }
        public virtual ICollection<ToolInvOnMachine> ToolInvOnMachines { get; set; }
        public virtual ICollection<TrackingRepairEmployee> TrackingRepairEmployees { get; set; }
        public virtual ICollection<TrackUpMachine> TrackUpMachines { get; set; }
        public virtual ICollection<TransactionDetail> TransactionDetails { get; set; }
        public virtual ICollection<WorkOrderRouting> WorkOrderRoutings { get; set; }
    }
}
