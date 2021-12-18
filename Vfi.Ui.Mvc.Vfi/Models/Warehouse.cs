using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class Warehouse
    {
        public Warehouse()
        {
            this.ProductionPlans = new List<ProductionPlan>();
            this.DefectTransactionDetails = new List<DefectTransactionDetail>();
            this.MachineAppraisals = new List<MachineAppraisal>();
            this.ProcessingTypes = new List<ProcessingType>();
            this.ProductionDefectRemedies = new List<ProductionDefectRemedy>();
            this.ProductionProcesses = new List<ProductionProcess>();
            this.ProductionProcessByMachines = new List<ProductionProcessByMachine>();
            this.ProductionTools = new List<ProductionTool>();
            this.SmartProductions = new List<SmartProduction>();
            this.ProductInventories = new List<ProductInventory>();
            this.ProductInventoryPeriods = new List<ProductInventoryPeriod>();
            this.StockOrders = new List<StockOrder>();
            this.StockOrders1 = new List<StockOrder>();
            this.Transactions = new List<Transaction>();
            this.Transactions1 = new List<Transaction>();
            this.ForecastOrderDetails = new List<ForecastOrderDetail>();
            this.OrderProgresses = new List<OrderProgress>();
            this.TimeLines = new List<TimeLine>();
            this.WarehousePermissions = new List<WarehousePermission>();
            this.WarehouseRotates = new List<WarehouseRotate>();
            this.WarehouseRotates1 = new List<WarehouseRotate>();
        }

        public int WarehouseId { get; set; }
        public Nullable<int> WarehouseTypeId { get; set; }
        public string WarehouseName { get; set; }
        public string Description { get; set; }
        public int Idx { get; set; }
        public bool DisplayInReport { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ShortName { get; set; }
        public bool CanInternal { get; set; }
        public bool CanPurchase { get; set; }
        public bool IsHeatTreatment { get; set; }
        public bool IsPolish { get; set; }
        public bool IsReprocessing { get; set; }
        public bool IsProduction2 { get; set; }
        public bool IsProduction2Process { get; set; }
        public bool IsMainProcess { get; set; }
        public bool IsQC { get; set; }
        public bool IsPlating { get; set; }
        public bool CanStock { get; set; }
        public bool IsOutOfProcess { get; set; }
        public virtual ICollection<ProductionPlan> ProductionPlans { get; set; }
        public virtual ICollection<DefectTransactionDetail> DefectTransactionDetails { get; set; }
        public virtual ICollection<MachineAppraisal> MachineAppraisals { get; set; }
        public virtual ICollection<ProcessingType> ProcessingTypes { get; set; }
        public virtual ICollection<ProductionDefectRemedy> ProductionDefectRemedies { get; set; }
        public virtual ICollection<ProductionProcess> ProductionProcesses { get; set; }
        public virtual ICollection<ProductionProcessByMachine> ProductionProcessByMachines { get; set; }
        public virtual ICollection<ProductionTool> ProductionTools { get; set; }
        public virtual ICollection<SmartProduction> SmartProductions { get; set; }
        public virtual ICollection<ProductInventory> ProductInventories { get; set; }
        public virtual ICollection<ProductInventoryPeriod> ProductInventoryPeriods { get; set; }
        public virtual ICollection<StockOrder> StockOrders { get; set; }
        public virtual ICollection<StockOrder> StockOrders1 { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual ICollection<Transaction> Transactions1 { get; set; }
        public virtual ICollection<ForecastOrderDetail> ForecastOrderDetails { get; set; }
        public virtual ICollection<OrderProgress> OrderProgresses { get; set; }
        public virtual ICollection<TimeLine> TimeLines { get; set; }
        public virtual WarehouseType WarehouseType { get; set; }
        public virtual ICollection<WarehousePermission> WarehousePermissions { get; set; }
        public virtual ICollection<WarehouseRotate> WarehouseRotates { get; set; }
        public virtual ICollection<WarehouseRotate> WarehouseRotates1 { get; set; }
    }
}
