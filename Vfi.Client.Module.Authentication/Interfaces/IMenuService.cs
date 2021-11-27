
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Client.Module.Authentication.Interfaces
{
    public interface IMenuService
    {
        IEnumerable<Menu> GetMenu();

        IEnumerable<Menu> GetAllByLevel(int level);

        IEnumerable<Menu> GetAllByLevel(int level, bool asc);

        IEnumerable<Menu> GetMenuByParentId(int parentId);

        IEnumerable<Menu> GetMenuRoot();
    }
}
