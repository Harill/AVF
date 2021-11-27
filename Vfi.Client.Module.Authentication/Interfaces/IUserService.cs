
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.System;

namespace Vfi.Client.Module.Authentication.Interfaces
{
    public interface IUserService
    {
        int PasswordLength { get; }

        string ValidateUser(string username, string password, string value);

        int ChangePassword(string username, string oldPassword, string newPassword);

        User GetUserByUsername(string username);

        IEnumerable<User> GetUsers();

        User GetUserAdmin();

        bool CheckUser(User user);

        bool SaveUser(UserModel userModel);

        bool CreateNewUser(UserModel userModel);

        bool CreateNewUser(User user);

        bool DeleteUser(UserModel userModel);

        bool DeleteUser(int userId);

        bool DeleteUser(User user);

        User GetUserById(int userId);
    }
}
