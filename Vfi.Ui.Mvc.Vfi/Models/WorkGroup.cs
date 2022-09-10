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
        public bool Active { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string Theme { get; set; }
        public string BackgroundImage { get; set; }
        public string LogoImage { get; set; }
        public string ImagePath { get; set; }
        public string PageTitleColor { get; set; }
        public string CompanyName { get; set; }
        public string CompanyFullName { get; set; }
        public string CompanyShortName { get; set; }
        public string Address { get; set; }
        public string TelNumber { get; set; }
        public string FaxNumber { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public virtual ICollection<Permission> Permissions { get; set; }
        public virtual ICollection<UserWorkGroup> UserWorkGroups { get; set; }
    }
}
