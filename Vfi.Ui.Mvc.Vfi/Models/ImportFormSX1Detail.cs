using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ImportFormSX1Detail
    {
        public int DetailId { get; set; }
        public int ImportId { get; set; }
        public string Shift1 { get; set; }
        public double Number1 { get; set; }
        public double DefectProduct1 { get; set; }
        public string Shift2 { get; set; }
        public double Number2 { get; set; }
        public double DefectProduct2 { get; set; }
        public string Machine { get; set; }
        public int ProductId { get; set; }
        public Nullable<int> MachineId { get; set; }
        public Nullable<int> MaterialInvId { get; set; }
        public double MaterialUse1 { get; set; }
        public double MaterialUse2 { get; set; }
        public int ProductionRate { get; set; }
        public double Processing1 { get; set; }
        public double Processing2 { get; set; }
        public double ProductWeight { get; set; }
        public Nullable<int> UseDetailId { get; set; }
        public string LotNumber { get; set; }
        public Nullable<int> WarehouseExportId { get; set; }
        public Nullable<int> ProcessByMachineId { get; set; }
        public string UnitMeasure { get; set; }
        public virtual Machine Machine1 { get; set; }
        public virtual ImportFormSX1 ImportFormSX1 { get; set; }
        public virtual MaterialInventory MaterialInventory { get; set; }
        public virtual MaterialUseDetail MaterialUseDetail { get; set; }
        public virtual Product Product { get; set; }
    }
}
