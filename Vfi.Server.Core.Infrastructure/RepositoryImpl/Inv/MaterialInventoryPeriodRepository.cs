
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.Repository.Inv;

namespace Vfi.Server.Core.Infrastructure.RepositoryImpl.Inv
{
    public class MaterialInventoryPeriodRepository : GenericRepository<MaterialInventoryPeriod>, IMaterialInventoryPeriodRepository
    {
        public MaterialInventoryPeriodRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) { }
    }
}
