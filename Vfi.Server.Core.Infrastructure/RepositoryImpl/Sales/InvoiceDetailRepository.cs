
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.Repository.Sales;

namespace Vfi.Server.Core.Infrastructure.RepositoryImpl.Sales
{
    public class InvoiceDetailRepository : GenericRepository<InvoiceDetail>, IInvoiceDetailRepository
    {
        public InvoiceDetailRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) { }
    }
}
