using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ImportFormCncDetail
    {
        public int DetailId { get; set; }
        public int ImportId { get; set; }
        public int MachineId { get; set; }
        public int ProductId { get; set; }
        public double ProductWeight { get; set; }
        public double Number1 { get; set; }
        public double Processing1 { get; set; }
        public double DefectProduct1 { get; set; }
        public double Number2 { get; set; }
        public double Processing2 { get; set; }
        public double DefectProduct2 { get; set; }
        public double Rate { get; set; }
        public double Productivity { get; set; }
        public Nullable<int> ProductInvId { get; set; }
        public virtual Machine Machine { get; set; }
        public virtual ImportFormCnc ImportFormCnc { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProductInventory ProductInventory { get; set; }
    }
}
