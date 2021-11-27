using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ExportMaterialDetail
    {
        public long ExportDetailId { get; set; }
        public long ExportId { get; set; }
        public int MaterialId { get; set; }
        public Nullable<int> MachineId { get; set; }
        public double Quantity { get; set; }
        public Nullable<double> QuantityKg { get; set; }
        public int MaterialInvId { get; set; }
        public Nullable<long> TransactionDetailId { get; set; }
        public virtual Machine Machine { get; set; }
        public virtual ExportMaterial ExportMaterial { get; set; }
        public virtual Material Material { get; set; }
        public virtual MaterialInventory MaterialInventory { get; set; }
        public virtual TransactionDetail TransactionDetail { get; set; }
    }
}
