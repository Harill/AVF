
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.Repository.System
{
    // victor.j.thangs2 2010.10.20 6.50 am
    public interface IFunctionRepository : IGenericRepository<Function>
    {
        #region interface IFunctionRepository

        IEnumerable<Function> GetAllFunction();

        #endregion
    }

    
}
