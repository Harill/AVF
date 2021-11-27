
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.DataModel.Models.System
{
    public class PermissionModel
    {
        public virtual bool Creation { get; set; }

        public virtual bool Modification { get; set; }

        public virtual bool Deletion { get; set; }

        public virtual bool Execution { get; set; }

        public User User { get; set; }
        public virtual Function Function { get; set; }
    }

    public class FuncPer
    {
        public virtual long FunctionId { get; set; }

        public virtual string FunctionCode { get; set; }

        public virtual string FunctionName { get; set; }

        public virtual bool Creation { get; set; }

        public virtual bool Modification { get; set; }

        public virtual bool Deletion { get; set; }

        public virtual bool Execution { get; set; }
    }

    public class PermissionCreateModel
    {
        public virtual int Creation { get; set; }

        public virtual int Modification { get; set; }

        public virtual int Deletion { get; set; }

        public virtual int Execution { get; set; }

        public virtual string Discription { get; set; }

        public virtual Function Function { get; set; }

        public virtual User User { get; set; }

        public virtual WorkGroup Group { get; set; }

        public List<User> UserList { get; set; }

        public List<WorkGroup> GroupList { get; set; }

        public List<FuncPer> FuncPer { get; set; }

        public string SelectedUser { get; set; }

        public string SelectedWorkGroup { get; set; }

        public string[] PermissionIds { get; set; }

        public virtual PermissionModel PermissionModel { get; set; }
    }
}
