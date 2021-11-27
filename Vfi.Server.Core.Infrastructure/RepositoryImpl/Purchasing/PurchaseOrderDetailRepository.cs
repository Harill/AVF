
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.Repository.Purchasing;

namespace Vfi.Server.Core.Infrastructure.RepositoryImpl.Purchasing
{
    public class PurchaseOrderDetailRepository : GenericRepository<PurchaseOrderDetail>, IPurchaseOrderDetailRepository
    {
        public PurchaseOrderDetailRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) { }
    }
}
