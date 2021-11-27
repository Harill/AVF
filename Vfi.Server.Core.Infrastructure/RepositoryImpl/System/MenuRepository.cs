
using System.Collections.Generic;
using System.Linq;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.Repository.System;

namespace Vfi.Server.Core.Infrastructure.RepositoryImpl.System
{
    public class MenuRepository : GenericRepository<Menu>, IMenuRepository
    {
        public MenuRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) { }

        public IEnumerable<Menu> GetAllByLevel(int level, bool asc)
        {
            return GetAll().Where(m => m.MenuLevel == level);
        }

        public IEnumerable<Menu> GetAllByLevel(int level)
        {
            return GetAllByLevel(level, true);
        }

        public IEnumerable<Menu> GetMenuByParentId(int parentId)
        {
            return GetAll().Where(m => m.ParentId == parentId);
        }

        public IEnumerable<Menu> GetMenu()
        {
            //throw new NotImplementedException();
            return GetAll().OrderBy(f=>f.IDX).Where(f=>f.Active.HasValue && f.Active == true);
        }

        public IEnumerable<Menu> GetMenuRoot()
        {
            //throw new NotImplementedException();
            return GetAll().Where(m => m.ParentId == null).Where(f => f.Active.HasValue && f.Active == true).OrderBy(f => f.IDX);
        }
    }
}
