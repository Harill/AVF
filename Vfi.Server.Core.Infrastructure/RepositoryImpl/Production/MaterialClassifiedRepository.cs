
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.Repository.Production;

namespace Vfi.Server.Core.Infrastructure.RepositoryImpl.Production
{
    public class MaterialClassifiedRepository: GenericRepository<MaterialClassified>, IMaterialClassifiedRepository
    {
        public MaterialClassifiedRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) { }
    }
}
