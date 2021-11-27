
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;


namespace Vfi.Server.Core.Repository.System
{
    public interface IUserRepository : IGenericRepository<User>
    {
        #region Permission

        User GetUserActive(string username, string password);

        User GetUserAdmin();

        IEnumerable<User> GetUsers();

        void SaveUser(User user);

        bool CheckUser(int userId, string username);

        bool CreateNewUser(User user);

        User GetUserById(int userId);

        bool DeleteUser(User user);

        #endregion
    }
}
