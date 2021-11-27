
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Client.Module.Production.Interfaces
{
    public interface IParameterService
    {
        IEnumerable<Parameter> GetAllParameters();

        string CreateParameter(Parameter parameter);
        string UpdateParameter(Parameter parameter);
    }
}
