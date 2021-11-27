
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.Repository.Purchasing;

namespace Vfi.Server.Core.Infrastructure.RepositoryImpl.Purchasing
{
    public class VendorRepository : GenericRepository<Vendor>, IVendorRepository
    {
        public VendorRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) { }
    }
}
