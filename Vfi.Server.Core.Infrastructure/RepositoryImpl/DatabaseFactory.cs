using System;
using Vfi.Server.Core.Infrastructure.DataContext;

namespace Vfi.Server.Core.Infrastructure.RepositoryImpl
{
    public interface IDatabaseFactory
    {
        VfiEntities GetInstance();
    }
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private VfiEntities _dataContext;
        public VfiEntities GetInstance()
        {
            return _dataContext ?? (_dataContext = new VfiEntities());
        }

        public override void Terminate()
        {
            if (_dataContext != null)
                _dataContext.Dispose();
        }
    }

    public class Disposable : IDisposable
    {
        private bool _isDisposed;

        ~Disposable()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            if (!_isDisposed && disposing)
            {
                Terminate();
            }

            _isDisposed = true;
        }
        public virtual void Terminate()
        {
        }
    }
}
