
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.Repository.Purchasing;

namespace Vfi.Server.Core.Infrastructure.RepositoryImpl.Purchasing
{
    public class ShipMethodRepository : GenericRepository<ShipMethod>, IShipMethodRepository
    {
        public ShipMethodRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) { }
    }
}
