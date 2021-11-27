
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Client.Module.Authentication.Interfaces
{
    public interface IPermissionService
    {
        IEnumerable<Permission> GetPermissionPerUser(string username);

        List<int> AssignPermissionForUser(int[] functionIds, int userId);

        void DeletePermissionByUserId(int userId);
    }
}
