
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.Repository.Inv;

namespace Vfi.Server.Core.Infrastructure.RepositoryImpl.Inv
{
    public class StockOrderDetailRepository : GenericRepository<StockOrderDetail>, IStockOrderDetailRepository
    {
        public StockOrderDetailRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) { }
    }
}
