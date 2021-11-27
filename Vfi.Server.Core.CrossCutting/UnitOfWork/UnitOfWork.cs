using System;
using Microsoft.Practices.Unity;
using Vfi.Server.Core.Repository;

namespace Vfi.Server.Core.CrossCutting.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IRepositoryContext _repositoryContext;

        [InjectionConstructor]
        public UnitOfWork(IRepositoryContext repositoryContext)
        {
            if(_repositoryContext == null) _repositoryContext = repositoryContext;
        }

        public int SaveChanges()
        {
            try
            {
                return _repositoryContext.SaveChanges();
            }
            catch (Exception exp)
            {
                return 0;
            }
            
        }


        public void Terminate()
        {
            if (_repositoryContext != null)
                _repositoryContext.Terminate();
            GC.SuppressFinalize(this);
        }
    }
}
 