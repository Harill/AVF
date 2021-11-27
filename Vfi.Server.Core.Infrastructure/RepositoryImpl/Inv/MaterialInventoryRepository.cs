
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.Repository.Inv;

namespace Vfi.Server.Core.Infrastructure.RepositoryImpl.Inv
{
    public class MaterialInventoryRepository : GenericRepository<MaterialInventory>, IMaterialInventoryRepository
    {
        public MaterialInventoryRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) { }
    }
}
