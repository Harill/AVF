
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.Repository.Sales;

namespace Vfi.Server.Core.Infrastructure.RepositoryImpl.Sales
{
    public class CustomerTypeRepository : GenericRepository<CustomerType>, ICustomerTypeRepository
    {
        public CustomerTypeRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) { }
    }
}
