
using Vfi.Server.Core.Infrastructure.DataContext;
using Vfi.Server.Core.Repository;

namespace Vfi.Server.Core.Infrastructure.RepositoryImpl
{
    public class RepositoryContext : IRepositoryContext
    {
        private DatabaseFactory _factory;
        private readonly IDatabaseFactory _databaseFactory;
        protected DatabaseFactory Factory
        {
            get { return _factory ?? (_factory = new DatabaseFactory()); }
        }


        public RepositoryContext(IDatabaseFactory databaseFactory)
        {
            if (_databaseFactory == null) _databaseFactory = databaseFactory;
        }

        private VfiEntities _dbContext;
        public VfiEntities DataContext
        {
            get { return _dbContext ?? (_dbContext = _databaseFactory.GetInstance()); }
        }
        //protected VfiEntities DataContext
        //{
            //get { return _dbContext ?? (_dbContext = _databaseFactory.GetInstance()); }
        //}

        public int SaveChanges()
        {
            return DataContext.SaveChanges();
        }

        public void Terminate()
        {
            //ObjectContextManager.SetRepositoryContext(null);
            _factory.Terminate();
        }

    }
}
