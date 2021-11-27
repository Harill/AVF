
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.Repository.Inv;

namespace Vfi.Server.Core.Infrastructure.RepositoryImpl.Inv
{
    public class ProductInventoryPeriodRepository : GenericRepository<ProductInventoryPeriod>, IProductInventoryPeriodRepository
    {
        public ProductInventoryPeriodRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) { }
    }
}
