
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Client.Module.Authentication.Interfaces
{
    public interface IFunctionService
    {
        IEnumerable<Function> GetAllFunction();
    }
}
