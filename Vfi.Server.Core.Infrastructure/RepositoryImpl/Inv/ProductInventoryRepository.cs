
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.Repository.Inv;

namespace Vfi.Server.Core.Infrastructure.RepositoryImpl.Inv
{
    public class ProductInventoryRepository : GenericRepository<ProductInventory>, IProductInventoryRepository
    {
        public ProductInventoryRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) { }
    }
}
