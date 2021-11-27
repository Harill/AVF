using System;
using System.Collections.Generic;

namespace Vfi.Server.Core.DrivenModel.Models
{
    public partial class Menu
    {
        public Menu()
        {
            Menu1 = new List<Menu>();
        }

        public int MenuId { get; set; }
        public string MenuCode { get; set; }
        public string MenuName { get; set; }
        public Nullable<int> ParentId { get; set; }
        public Nullable<byte> MenuLevel { get; set; }
        public string ProjectName { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string Area { get; set; }
        public string Description { get; set; }
        public Nullable<byte> IDX { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual ICollection<Menu> Menu1 { get; set; }
        public virtual Menu Menu2 { get; set; }
    }
}
