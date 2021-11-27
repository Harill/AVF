
using System.Collections.Generic;
using System.Text;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.Repository.System;

namespace Vfi.Server.Core.Infrastructure.RepositoryImpl.System
{
    public class PermissionRepository : GenericRepository<Permission>, IPermissionRepository
    {
        public PermissionRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) { }

        public IEnumerable<Permission> GetPermissionByUsername(string username)
        {
            return Find(f => f.User.Username == (username));
        }

        public IEnumerable<Permission> GetPermissionByUserId(int userId)
        {
            return Find(f => f.UserID == userId);
        }
    }
}
