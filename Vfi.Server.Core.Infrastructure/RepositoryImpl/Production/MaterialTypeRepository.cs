
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.Repository.Production;

namespace Vfi.Server.Core.Infrastructure.RepositoryImpl.Production
{
    public class MaterialTypeRepository : GenericRepository<MaterialType>, IMaterialTypeRepository
    {
        public MaterialTypeRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) { }
    }
}
