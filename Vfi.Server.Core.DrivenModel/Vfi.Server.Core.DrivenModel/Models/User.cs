using System;
using System.Collections.Generic;

namespace Vfi.Server.Core.DrivenModel.Models
{
    public partial class User
    {
        public User()
        {
            Permissions = new List<Permission>();
            UserWorkGroups = new List<UserWorkGroup>();
        }

        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual ICollection<Permission> Permissions { get; set; }
        public virtual ICollection<UserWorkGroup> UserWorkGroups { get; set; }
    }
}
