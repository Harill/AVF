using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class MachineLog
    {
        public int LogId { get; set; }
        public Nullable<int> MachineId { get; set; }
        public string ModifiedUser { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string Note { get; set; }
        public int Type { get; set; }
        public Nullable<System.DateTime> DateLog { get; set; }
        public virtual Machine Machine { get; set; }
    }
}
