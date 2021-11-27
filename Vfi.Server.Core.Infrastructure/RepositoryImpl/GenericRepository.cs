using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
//using System.Data.Objects;
using System.Linq;
using System.Reflection;
using Vfi.Server.Core.Infrastructure.DataContext;
using Vfi.Server.Core.Repository;

namespace Vfi.Server.Core.Infrastructure.RepositoryImpl
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private VfiEntities _dbContext;
        private readonly IDbSet<T> _dbset;
        //private readonly ObjectSet<T> _dbset;
        private readonly IDatabaseFactory _databaseFactory;
        protected GenericRepository(IDatabaseFactory databaseFactory)
        {
            //DatabaseFactory = databaseFactory;
            if (_databaseFactory == null) _databaseFactory = databaseFactory;

            Assembly.Load("Vfi.Server.Core.Infrastructure");
            _dbset = DataContext.Set<T>();

            
            //_dbset = DataContext.CreateObjectSet<T>();

            //_dbContext.Warehouses.MergeOption = MergeOption.NoTracking;
        }

        protected IDatabaseFactory DatabaseFactory
        {
            get;
            private set;
        }

        protected VfiEntities DataContext
        {
            get { return _dbContext ?? (_dbContext = _databaseFactory.GetInstance()); }
        }

        // setup context

        // function
        public virtual IEnumerable<T> GetAll()
        {
            var adp = _dbContext as IObjectContextAdapter;

            return _dbset;
        }
        public IEnumerable<T> GetAllAsNoTracking()
        {
            return _dbset.AsNoTracking();
        }

        public virtual IEnumerable<T> Find(Func<T, bool> where)
        {
            //throw new NotImplementedException();
            return _dbset.Where(where);
        }
        public virtual IEnumerable<T> FindAsNoTracking(Func<T, bool> where)
        {
            //throw new NotImplementedException();
            //return _dbset.AsNoTracking().Where(where);
            return _dbset.AsNoTracking().Where(where);
        }

        public virtual IEnumerable<T> GetAllAndChildren(string children)
        {
            return _dbset.Include(children);
        }

        public IEnumerable<T> GetAllAndChildren(string[] children)
        {
            throw new NotImplementedException();
        }

        public T Single(Func<T, bool> where)
        {
            //throw new NotImplementedException();
            return _dbset.Single(where);
        }
        public T First(Func<T, bool> where)
        {
            //throw new NotImplementedException();
            return _dbset.First(where);
        }

        public void Add(T entity)
        {
            //throw new NotImplementedException();
            //ObjectContext.AddObject(entity);
            //ObjectContext.AddObject(GetBaseType(typeof(T)).Name, entity);
            _dbset.Add(entity);
            //_dbset.AddObject(entity);
        }

        public void Delete(T entity)
        {
            //throw new NotImplementedException();
            _dbset.Remove(entity);
            //_dbset.AddObject(entity);
        }
        public void Delete(Func<T, bool> predicate)
        {
            var objects = _dbset.Where<T>(predicate).AsEnumerable();
            foreach (var obj in objects)
                _dbset.Remove(obj);
                //_dbset.DeleteObject(obj);
        }
    }
}
