
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.Repository.Inv;

namespace Vfi.Server.Core.Infrastructure.RepositoryImpl.Inv
{
    public class TransactionDetailRepository : GenericRepository<TransactionDetail>, ITransactionDetailRepository
    {
        public TransactionDetailRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) { }
    }
}
