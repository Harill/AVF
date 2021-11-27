
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.Repository.Sales;

namespace Vfi.Server.Core.Infrastructure.RepositoryImpl.Sales
{
    public class TimeLineRepository : GenericRepository<TimeLine>, ITimeLineRepository
    {
        public TimeLineRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) { }
    }
}
