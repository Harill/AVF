using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class User
    {
        public User()
        {
            this.CustomerAccessPermissions = new List<CustomerAccessPermission>();
            this.Employees = new List<Employee>();
            this.Permissions = new List<Permission>();
            this.UserWorkGroups = new List<UserWorkGroup>();
            this.WarehousePermissions = new List<WarehousePermission>();
        }

        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual ICollection<CustomerAccessPermission> CustomerAccessPermissions { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Permission> Permissions { get; set; }
        public virtual ICollection<UserWorkGroup> UserWorkGroups { get; set; }
        public virtual ICollection<WarehousePermission> WarehousePermissions { get; set; }
    }
}
