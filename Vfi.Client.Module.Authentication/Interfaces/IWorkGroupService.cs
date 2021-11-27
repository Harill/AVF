
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.System;

namespace Vfi.Client.Module.Authentication.Interfaces
{
    public interface IWorkGroupService
    {
        IEnumerable<WorkGroup> GetAllWorkGroups();

        IEnumerable<WorkGroup> GetAllWorkGroupActive();

        WorkGroup GetWorkGroupById(int workGroupId);

        void CreateWorkGroup(WorkGroupModel workGroupModel);

        void UpdateWorkGroup(WorkGroupModel workGroupModel);

        void DeleteWorkGroup(int workGroupId);
    }
}
