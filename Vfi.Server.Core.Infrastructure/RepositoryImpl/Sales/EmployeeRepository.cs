
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.Repository.Sales;

namespace Vfi.Server.Core.Infrastructure.RepositoryImpl.Sales
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) { }
    }
}
