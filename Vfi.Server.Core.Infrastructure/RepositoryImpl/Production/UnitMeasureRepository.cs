
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.Repository.Production;

namespace Vfi.Server.Core.Infrastructure.RepositoryImpl.Production
{
    public class UnitMeasureRepository : GenericRepository<UnitMeasure>, IUnitMeasureRepository
    {
        public UnitMeasureRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) { }
    }
}
