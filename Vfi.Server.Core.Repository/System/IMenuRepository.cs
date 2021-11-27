
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.Repository.System
{
    // victor.j.thangs2 2010.10.20 6.30 am
    public interface IMenuRepository : IGenericRepository<Menu>
    {
        #region interface IMenuRepository

        IEnumerable<Menu> GetAllByLevel(int level, bool asc);

        IEnumerable<Menu> GetMenuByParentId(int parentId);

        IEnumerable<Menu> GetMenu();

        IEnumerable<Menu> GetMenuRoot();

        #endregion
    }
}
