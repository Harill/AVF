
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.Repository.Purchasing;

namespace Vfi.Server.Core.Infrastructure.RepositoryImpl.Purchasing
{
    public class PriceListMaterialRepository : GenericRepository<PriceListMaterial>, IPriceListMaterialRepository
    {
        public PriceListMaterialRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) { }
    }
}
