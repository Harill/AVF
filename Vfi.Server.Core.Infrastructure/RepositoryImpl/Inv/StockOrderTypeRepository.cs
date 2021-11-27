
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.Repository.Inv;

namespace Vfi.Server.Core.Infrastructure.RepositoryImpl.Inv
{
    public class StockOrderTypeRepository : GenericRepository<StockOrderType>, IStockOrderTypeRepository
    {
        public StockOrderTypeRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) { }
    }
}
