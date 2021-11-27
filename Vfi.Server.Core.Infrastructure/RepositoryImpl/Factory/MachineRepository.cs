
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.Repository.Factory;

namespace Vfi.Server.Core.Infrastructure.RepositoryImpl.Factory
{
    public class MachineRepository : GenericRepository<Machine>, IMachineRepository
    {
        public MachineRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) { }
    }
}
