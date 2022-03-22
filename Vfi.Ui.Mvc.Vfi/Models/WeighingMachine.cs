using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class WeighingMachine
    {
        public int MachineId { get; set; }
        public string MachineCode { get; set; }
        public string MachineName { get; set; }
        public int WarehouseId { get; set; }
        public string Port { get; set; }
        public string BaudRate { get; set; }
        public string DataBits { get; set; }
        public string Parity { get; set; }
        public string StopBit { get; set; }
        public bool Active { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
