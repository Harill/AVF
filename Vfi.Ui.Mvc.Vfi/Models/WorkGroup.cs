using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class WorkGroup
    {
        public WorkGroup()
        {
            this.Permissions = new List<Permission>();
            this.UserWorkGroups = new List<UserWorkGroup>();
        }

        public int WorkGroupId { get; set; }
        public string WorkGroupCode { get; set; }
        public string WorkGroupName { get; set; }
        public string Description { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual ICollection<Permission> Permissions { get; set; }
        public virtual ICollection<UserWorkGroup> UserWorkGroups { get; set; }
    }
}
