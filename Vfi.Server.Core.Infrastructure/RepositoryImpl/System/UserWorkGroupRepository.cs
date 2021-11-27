using System;
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.Repository.System;

namespace Vfi.Server.Core.Infrastructure.RepositoryImpl.System
{
    public class UserWorkGroupRepository : GenericRepository<UserWorkGroup>, IUserWorkGroupRepository
    {
        public UserWorkGroupRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) { }

        public void CreateUserWorkGroup(User user, WorkGroup workGroup)
        {
            var userWorkGroup = new UserWorkGroup
            {
                UserId = user.UserId,
                WorkGoupId = workGroup.WorkGroupId,
                ModifiedDate = DateTime.Now
            };
            Add(userWorkGroup);
            //SaveChanges();
        }

        public void AddListUserWorkGroup(IEnumerable<User> users, IEnumerable<WorkGroup> workGroups)
        {
            var listUserWorkGroup = new UserWorkGroup();

            foreach (var workGroup in workGroups)
            {
                foreach (var user in users)
                {
                    //listUserWorkGroup.UserID = user.UserID;
                    //listUserWorkGroup.WorkGoupID = workGroup.WorkGroupID;

                    CreateUserWorkGroup(user, workGroup);
                }
            }
        }
    }
}
