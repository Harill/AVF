using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ProductionProcessByMachine
    {
        public ProductionProcessByMachine()
        {
            this.TransactionDetails = new List<TransactionDetail>();
        }

        public int DetailId { get; set; }
        public int MachineId { get; set; }
        public int ProcessIndex { get; set; }
        public bool Active { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public string Note { get; set; }
        public int ProductId { get; set; }
        public double UnitWeight { get; set; }
        public int WarehouseId { get; set; }
        public virtual Machine Machine { get; set; }
        public virtual Product Product { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual ICollection<TransactionDetail> TransactionDetails { get; set; }
    }
}
