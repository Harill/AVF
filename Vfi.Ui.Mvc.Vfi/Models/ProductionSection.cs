using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ProductionSection
    {
        public ProductionSection()
        {
            this.MachineRepairForms = new List<MachineRepairForm>();
            this.Production2Inventory = new List<Production2Inventory>();
            this.Production2TransactionDetail = new List<Production2TransactionDetail>();
            this.Production2TransactionDetail1 = new List<Production2TransactionDetail>();
            this.SectionLogs = new List<SectionLog>();
            this.SmartProduction2 = new List<SmartProduction2>();
            this.SmartProduction21 = new List<SmartProduction2>();
        }

        public int ProductionSectionId { get; set; }
        public string SectionName { get; set; }
        public Nullable<double> SectionCost { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> InsertDate { get; set; }
        public string InsertUser { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string UpdateUser { get; set; }
        public bool Active { get; set; }
        public int ProductId { get; set; }
        public int SectionIndex { get; set; }
        public double Productivity { get; set; }
        public int SectionId { get; set; }
        public double Weight { get; set; }
        public Nullable<int> MachineId { get; set; }
        public bool IsMainProcess { get; set; }
        public virtual Machine Machine { get; set; }
        public virtual ICollection<MachineRepairForm> MachineRepairForms { get; set; }
        public virtual ICollection<Production2Inventory> Production2Inventory { get; set; }
        public virtual ICollection<Production2TransactionDetail> Production2TransactionDetail { get; set; }
        public virtual ICollection<Production2TransactionDetail> Production2TransactionDetail1 { get; set; }
        public virtual Product Product { get; set; }
        public virtual Section Section { get; set; }
        public virtual ICollection<SectionLog> SectionLogs { get; set; }
        public virtual ICollection<SmartProduction2> SmartProduction2 { get; set; }
        public virtual ICollection<SmartProduction2> SmartProduction21 { get; set; }
    }
}
