
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.Factory;

namespace Vfi.Client.Module.Factory.Interfaces
{
    public interface IToolService
    {
        IEnumerable<Tool> GetAllTools();
        IEnumerable<ToolDomainModel> GetAllToolDomainModels();
        Tool GetToolById(int toolId);

        string CreateTool(Tool tool);
        string UpdateTool(Tool tool);
    }
}
