using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using Vfi.Client.Core.Common;
using Vfi.Client.Module.Authentication.Interfaces;
using Vfi.Server.Core.CrossCutting.UnitOfWork;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.System;
using Vfi.Server.Core.Repository.System;
using mis.common.genkey;

namespace Vfi.Client.Module.Authentication.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;
        [InjectionConstructor]
        public UserService(IUserRepository userRepository, IUnitOfWork unitOfWork )
        {
            if (_userRepository == null) _userRepository = userRepository;
            if (_unitOfWork == null) _unitOfWork = unitOfWork;
        }

        public int PasswordLength
        {
            get { throw new NotImplementedException(); }
        }

        public string ValidateUser(string username, string password, string value)
        {
            try
            {
                //var key = new GenKeyLics();
                //var ki = HashData.ComputeHash(key.GetUniqueId("C"), HashData.HashDataType.Sha512.ToString(), null);
                //var ko = HashData.ComputeHash(value , HashData.HashDataType.Sha512.ToString(), null);

                //if (!ki.Equals(ko, StringComparison.OrdinalIgnoreCase))
                //    throw new ArgumentException("Hệ thống bị khóa.\n\rVui lòng liên hệ nhóm dự án để biết thêm chi tiết.");

                if (String.IsNullOrEmpty(username)) throw new ArgumentException("Value cannot be null or empty.", "username");
                if (String.IsNullOrEmpty(password)) throw new ArgumentException("Value cannot be null or empty.", "password");

                User user;
                try
                {
                    user = _userRepository.GetUserActive(username, HashData.ComputeHash(password, HashData.HashDataType.Sha512.ToString(), null));
                }
                catch(Exception exp)
                {
                    //throw new Exception(exp.Message);
                    return "2";
                }
                
                
                if (user != null)
                {
                    return user.Active == true ? "0" : "1";
                }
                return "2";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        // v.j.thangs2
        public int ChangePassword(string username, string oldPassword, string newPassword)
        {
            try
            {
                var user = _userRepository.GetUserActive(username, HashData.ComputeHash(oldPassword, HashData.HashDataType.Sha512.ToString(), null));

                if (user != null)
                {
                    //return user.Active == true ? 0 : 1;
                    if(user.Active != null)
                    {
                        user.Password = HashData.ComputeHash(newPassword, HashData.HashDataType.Sha512.ToString(), null);
                        return 0;
                    }
                    return 1;
                }

                return 2;
            }
            catch(Exception)
            {
                return 3;
            }
        }

        public User GetUserByUsername(string username)
        {
            if (username == "")
                return null;

            return _userRepository.GetUsers().Where(u => u.Username == (username) && u.Active == true).FirstOrDefault();
        }

        public IEnumerable<User> GetUsers()
        {
            var userAccounts =_userRepository.GetUsers();

            var listUserAccountModels = userAccounts.Select
                (user => new User
                    {
                        UserId = user.UserId,
                        Username = user.Username.ToString(),
                        Password = user.Password,
                        Active = user.Active != null && (bool) user.Active,
                        Email = user.Email,
                        FullName = user.FullName,
                        //ModifiedDate = user.ModifiedDate
                    }).ToList();

            return listUserAccountModels;
        }

        public User GetUserAdmin()
        {
            //throw new NotImplementedException();
            return _userRepository.GetUserAdmin();
        }

        public bool CheckUser(User user)
        {
            
            return false;
        }

        public bool SaveUser(UserModel userModel)
        {
            //throw new NotImplementedException();
            //var user = new User
            //{
            //    UserID = userModel.UserId,
            //    Username = userModel.Username,
            //    //Password = HashData.ComputeHash("abcd123456", HashData.HashDataType.Sha512.ToString(), null),
            //    FullName = userModel.FullName,
            //    Email = userModel.Email,
            //    Active = userModel.Active,
            //    ModifiedDate = DateTime.Now
            //};

            
            try
            {
                //var target = GetUserById(user.UserID);
                //if (target != null)
                //{
                //    target.Username = user.Username;
                //    target.FullName = user.FullName;
                //    target.Email = user.Email;
                //    target.Active = user.Active;
                //    target.ModifiedDate = DateTime.Now;
                //}  
                var target = GetUserById(userModel.UserId);
                if (target != null)
                {
                    target.Username = (userModel.Username);
                    target.FullName = userModel.FullName;
                    target.Password =
                        (HashData.ComputeHash(userModel.Password, HashData.HashDataType.Sha512.ToString(), null));
                    target.Email = userModel.Email;
                    target.Active = userModel.Active;
                    target.ModifiedDate = DateTime.Now;
                }  

                //_userRepository.SaveUser();
                //_userRepository.SaveChanges();
                _unitOfWork.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool DeleteUser(UserModel userModel)
        {
            //throw new NotImplementedException();
            var target = GetUserById(userModel.UserId);

            try
            {
                if (target != null)
                {
                    var user = new User { UserId = target.UserId };
                    _userRepository.DeleteUser(user);
                    _unitOfWork.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return false;
        }

        public bool DeleteUser(int userId)
        {
            var target = GetUserById(userId);

            try
            {
                if (target != null)
                {
                    //var user = new User { UserID = target.UserID };
                    _userRepository.DeleteUser(target);
                    _unitOfWork.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return false;
        }

        public bool DeleteUser(User user)
        {
            var target = GetUserById(user.UserId);

            try
            {
                if (target != null)
                {
                    //var user = new User { UserID = target.UserID };
                    _userRepository.DeleteUser(target);
                    _unitOfWork.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return false;

        }

        public bool CreateNewUser(UserModel userModel)
        {
            //throw new NotImplementedException();
            var user = new User
                           {
                               Username = (userModel.Username),
                               //Password = HashData.ComputeHash("abcd123456", HashData.HashDataType.Sha512.ToString(), null),
                               Password = (HashData.ComputeHash(userModel.Password, HashData.HashDataType.Sha512.ToString(), null)),
                               FullName = userModel.FullName,
                               Email = userModel.Email,
                               Active = userModel.Active,
                               ModifiedDate = DateTime.Now
                           };
            try
            {
                _userRepository.CreateNewUser(user);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CreateNewUser(User user)
        {
            //throw new NotImplementedException();
            try
            {
                _userRepository.CreateNewUser(user);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public User GetUserById(int userId)
        {
            //throw new NotImplementedException();
           return _userRepository.GetUserById(userId);
        }

    }
}
