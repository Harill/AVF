using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class DefectTransactionDetail
    {
        public long DetailId { get; set; }
        public long TransactionId { get; set; }
        public int ProductId { get; set; }
        public string Note { get; set; }
        public Nullable<int> MachineId { get; set; }
        public double QuantityDefect { get; set; }
        public bool Destroy { get; set; }
        public bool Recheck { get; set; }
        public bool Reprocess { get; set; }
        public int DefectId { get; set; }
        public Nullable<int> NextWarehouseProcessId { get; set; }
        public Nullable<int> RemedyId { get; set; }
        public int Shift { get; set; }
        public string DefectExpand { get; set; }
        public Nullable<long> ReferenceDetailId { get; set; }
        public string StoreCode { get; set; }
        public virtual DefectTransaction DefectTransaction { get; set; }
        public virtual Machine Machine { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProductionDefect ProductionDefect { get; set; }
        public virtual ProductionDefectRemedy ProductionDefectRemedy { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
