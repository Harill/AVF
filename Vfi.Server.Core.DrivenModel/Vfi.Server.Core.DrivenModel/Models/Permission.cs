using System;
using System.Collections.Generic;

namespace Vfi.Server.Core.DrivenModel.Models
{
    public partial class Permission
    {
        public int PermissionId { get; set; }
        public Nullable<bool> Creation { get; set; }
        public Nullable<bool> Modification { get; set; }
        public Nullable<bool> Deletion { get; set; }
        public Nullable<bool> Execution { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> WorkGroupID { get; set; }
        public string Description { get; set; }
        public Nullable<int> FunctionID { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual Function Function { get; set; }
        public virtual User User { get; set; }
        public virtual WorkGroup WorkGroup { get; set; }
    }
}
