
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.Repository.Inv;

namespace Vfi.Server.Core.Infrastructure.RepositoryImpl.Inv
{
    public class StockOrderRepository : GenericRepository<StockOrder>, IStockOrderRepository
    {
        public StockOrderRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) { }
    }
}
