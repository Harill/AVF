using System;
using System.Collections.Generic;
using System.Linq;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.System;
using Vfi.Server.Core.Repository.System;

namespace Vfi.Server.Core.Infrastructure.RepositoryImpl.System
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) { }

        public User GetUserActive(string username, string password)
        {
            //throw new NotImplementedException();
            //return GetQuery().Where(u => u.Username == username && u.Password == password).FirstOrDefault();
            return Find(u => u.Username.Equals(username) && u.Password.Equals(password) && u.Active == true).FirstOrDefault();
            //return GetAll() as User;
        }

        public User GetUserAdmin()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsers()
        {
            //throw new NotImplementedException();
            return GetAll();
        }

        public void SaveUser(User user)
        {
            //throw new NotImplementedException();
            //var target = GetUserById(user.UserID);
            //if(target !=null)
            //{
            //    target.Username = user.Username;
            //    target.FullName = user.FullName;
            //    target.Email = user.Email;
            //    target.Active = user.Active;
            //    target.ModifiedDate = DateTime.Now;

            //    SaveChanges();
            //}   
            //SaveChanges();        
        }

        public bool CheckUser(int userId, string username)
        {
            //throw new NotImplementedException();
            var userChecked = First(u => u.UserId == userId && u.Username == (username));
            if (userChecked != null)
                return true;
            return false;
        }

        public bool CreateNewUser(User user)
        {
            //throw new NotImplementedException();
            try
            {
                Add(user);
                //SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw new Exception();
            }

        }

        public User GetUserById(int userId)
        {
            //throw new NotImplementedException();
            return First(u => u.UserId == userId);
        }

        public bool DeleteUser(User user)
        {
            //throw new NotImplementedException();
            Delete(user);
            return false;
        }
    }
}
