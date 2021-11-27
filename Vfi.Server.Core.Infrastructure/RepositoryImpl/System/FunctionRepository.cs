
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.Repository.System;

namespace Vfi.Server.Core.Infrastructure.RepositoryImpl.System
{
    public class FunctionRepository : GenericRepository<Function>, IFunctionRepository
    {
        public FunctionRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) { }

        public IEnumerable<Function> GetAllFunction()
        {
            //throw new NotImplementedException();
            return GetAll();
        }
    }
}
