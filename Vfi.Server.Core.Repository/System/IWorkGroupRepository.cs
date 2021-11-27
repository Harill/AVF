
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.Repository.System
{
    // victor.j.thangs2 2010.10.20 7.00 am
    public interface IWorkGroupRepository : IGenericRepository<WorkGroup>
    {
        #region interface IWorkGroupRepository

        IEnumerable<WorkGroup> GetAllWorkGroup(bool all, bool isActive);

        IEnumerable<WorkGroup> GetAllWorkGroup();

        void CreateWorkGroup(WorkGroup workGroup);

        void UpdateWorkGroup();

        void DeleteWorkGroup(WorkGroup workGroup);

        WorkGroup GetWorkGroupById(int workGroupId);

        #endregion
    }
}
