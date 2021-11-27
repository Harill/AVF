
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.Repository.Production;

namespace Vfi.Server.Core.Infrastructure.RepositoryImpl.Production
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) { }
    }
}
