using System;
using System.Collections.Generic;
using Microsoft.Practices.Unity;
using Vfi.Client.Module.Authentication.Interfaces;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.Repository.System;

namespace Vfi.Client.Module.Authentication.Services
{
    public class PermissionService : IPermissionService
    {
        private readonly IPermissionRepository _permissionRepository;
        [InjectionConstructor]
        public PermissionService(IPermissionRepository permissionRepository)
        {
            if (_permissionRepository == null) _permissionRepository = permissionRepository;
        }

        public IEnumerable<Permission> GetPermissionPerUser(string username)
        {
            try
            {
                var permissions = _permissionRepository.GetPermissionByUsername(username);

                return permissions;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public List<int> AssignPermissionForUser(int[] functionIds, int userId)
        {
            var result = new List<int>();
            try
            {
                var lstTarget = _permissionRepository.GetPermissionByUserId(userId);
                if (lstTarget != null)
                {
                    foreach (var permission in lstTarget)
                    {
                        // delete all by user
                        _permissionRepository.Delete(permission);
                    }
                }

                foreach (var t in functionIds)
                {
                    var entity = new Permission
                    {
                        Creation = true,
                        Deletion = true,
                        Execution = true,
                        Modification = true,
                        FunctionID = t,
                        ModifiedDate = DateTime.Now,
                        UserID = userId
                    };
                    _permissionRepository.Add(entity);
                    result.Add(1);
                }

                //_permissionRepository.SaveChanges();
            }
            catch (Exception)
            {
                result.Add(0);
                throw;
            }
            return result;
        }

        public void DeletePermissionByUserId(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
