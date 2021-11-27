
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.Repository.Sales;

namespace Vfi.Server.Core.Infrastructure.RepositoryImpl.Sales
{
    public class OrderDetailRepository : GenericRepository<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) { }
    }
}
