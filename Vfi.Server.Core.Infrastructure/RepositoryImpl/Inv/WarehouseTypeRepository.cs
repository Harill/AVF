
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.Repository.Inv;

namespace Vfi.Server.Core.Infrastructure.RepositoryImpl.Inv
{
    public class WarehouseTypeRepository : GenericRepository<WarehouseType>, IWarehouseTypeRepository
    {
        public WarehouseTypeRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) { }
    }
}
