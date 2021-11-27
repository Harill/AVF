using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class UserWorkGroup
    {
        public int UserId { get; set; }
        public int WorkGoupId { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual User User { get; set; }
        public virtual WorkGroup WorkGroup { get; set; }
    }
}
