
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.Repository.Production;

namespace Vfi.Server.Core.Infrastructure.RepositoryImpl.Production
{
    public class ParameterRepository: GenericRepository<Parameter>, IParameterRepository
    {
        public ParameterRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) { }
    }
}
