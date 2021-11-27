using System;
using System.Collections.Generic;

namespace Vfi.Server.Core.DrivenModel.Models
{
    public partial class Function
    {
        public Function()
        {
            Function1 = new List<Function>();
            Permissions = new List<Permission>();
        }

        public int FunctionId { get; set; }
        public Nullable<int> ParentId { get; set; }
        public string FunctionCode { get; set; }
        public string FunctionName { get; set; }
        public string Description { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<byte> IDx { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual ICollection<Function> Function1 { get; set; }
        public virtual Function Function2 { get; set; }
        public virtual ICollection<Permission> Permissions { get; set; }
    }
}
