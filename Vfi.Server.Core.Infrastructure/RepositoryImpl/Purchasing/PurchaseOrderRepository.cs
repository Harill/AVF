
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.Repository.Purchasing;

namespace Vfi.Server.Core.Infrastructure.RepositoryImpl.Purchasing
{
    public class PurchaseOrderRepository : GenericRepository<PurchaseOrder>, IPurchaseOrderRepository
    {
        public PurchaseOrderRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) { }
    }
}
