
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.Repository.Factory;

namespace Vfi.Server.Core.Infrastructure.RepositoryImpl.Factory
{
    public class ToolDetailRepository : GenericRepository<ToolDetail>, IToolDetailRepository
    {
        public ToolDetailRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) { }
    }
}
