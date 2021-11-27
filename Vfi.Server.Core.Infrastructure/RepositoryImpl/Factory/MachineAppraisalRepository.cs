
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.Repository.Factory;

namespace Vfi.Server.Core.Infrastructure.RepositoryImpl.Factory
{
    public class MachineAppraisalRepository : GenericRepository<MachineAppraisal>, IMachineAppraisalRepository
    {
        public MachineAppraisalRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) { }
    }
}
