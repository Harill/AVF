
using System.Collections.Generic;

using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.Repository.System
{
    public interface IUserWorkGroupRepository : IGenericRepository<UserWorkGroup>
    {
        void CreateUserWorkGroup(User user, WorkGroup workGroup);

        void AddListUserWorkGroup(IEnumerable<User> users, IEnumerable<WorkGroup> workGroups);
    }
}
