
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.Repository.Production;

namespace Vfi.Server.Core.Infrastructure.RepositoryImpl.Production
{
    public class CurrencyRepository : GenericRepository<Currency>, ICurrencyRepository
    {
        public CurrencyRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) { }
    }
}
