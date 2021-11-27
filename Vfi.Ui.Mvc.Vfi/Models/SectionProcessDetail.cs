using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class SectionProcessDetail
    {
        public int DetailId { get; set; }
        public int SectionId { get; set; }
        public int ProcessId { get; set; }
        public int ProductId { get; set; }
        public bool Active { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public int DetailIndex { get; set; }
        public virtual Section Section { get; set; }
        public virtual SectionProcess SectionProcess { get; set; }
        public virtual Product Product { get; set; }
    }
}
