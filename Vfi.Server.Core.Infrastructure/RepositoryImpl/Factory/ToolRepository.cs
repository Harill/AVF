
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.Repository.Factory;

namespace Vfi.Server.Core.Infrastructure.RepositoryImpl.Factory
{
    public class ToolRepository : GenericRepository<Tool>, IToolRepository
    {
        public ToolRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) { }
    }
}
