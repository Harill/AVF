
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.Repository.Factory;

namespace Vfi.Server.Core.Infrastructure.RepositoryImpl.Factory
{
    public class ToolPeriodRepository : GenericRepository<ToolPeriod>, IToolPeriodRepository
    {
        public ToolPeriodRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) { }
    }
}
