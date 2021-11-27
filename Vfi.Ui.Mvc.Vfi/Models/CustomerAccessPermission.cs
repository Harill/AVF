using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class CustomerAccessPermission
    {
        public int RoleId { get; set; }
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public string Note { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public bool Active { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual User User { get; set; }
    }
}
