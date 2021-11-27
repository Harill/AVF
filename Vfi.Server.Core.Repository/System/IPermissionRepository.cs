
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.Repository.System
{
    // victor.j.thangs2 2010.10.20 6.40 am
    public interface IPermissionRepository : IGenericRepository<Permission>
    {
        #region interface IPermissionRepository

        IEnumerable<Permission> GetPermissionByUsername(string username);

        IEnumerable<Permission> GetPermissionByUserId(int userId);

        #endregion
    }
}
