
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.DataModel.Models.System
{
    public class UserWorkGroupModel
    {
        public User User { get; set; }

        public WorkGroup WorkGroup { get; set; }

        public virtual PermissionModel PermissionModel { get; set; }
        public IList<PermissionModel> Permissions { get; set; }
    }
}
