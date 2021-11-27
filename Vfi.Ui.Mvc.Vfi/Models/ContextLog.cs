using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ContextLog
    {
        public long LogId { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public string LogText { get; set; }
    }
}
