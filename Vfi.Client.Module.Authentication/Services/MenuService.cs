using System.Linq;
using System.Collections.Generic;
using Microsoft.Practices.Unity;
using Vfi.Client.Module.Authentication.Interfaces;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.Repository.System;

namespace Vfi.Client.Module.Authentication.Services
{
    public class MenuService : IMenuService
    {
        private readonly IMenuRepository _menuRepository;
        [InjectionConstructor]
        public MenuService(IMenuRepository menuRepository)
        {
            if(_menuRepository == null) _menuRepository= menuRepository;
        }

        public IEnumerable<Menu> GetAllByLevel(int level)
        {
            return _menuRepository.GetAllByLevel(level, true);
        }

        public IEnumerable<Menu> GetAllByLevel(int level, bool asc)
        {
            return _menuRepository.GetAllByLevel(level, asc);
        }

        public IEnumerable<Menu> GetMenuByParentId(int parentId)
        {
            return _menuRepository.GetMenuByParentId(parentId);
        }

        public IEnumerable<Menu> GetMenu()
        {
            return _menuRepository.GetMenu().Where(f=>f.Active == true);
        }

        public IEnumerable<Menu> GetMenuRoot()
        {
            return _menuRepository.GetMenuRoot().Where(f=>f.Active == true);
        }
    }
}
