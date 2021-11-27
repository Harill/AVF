
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.Factory;

namespace Vfi.Client.Module.Factory.Interfaces
{
    public interface IMachineAppraisalService
    {
        IEnumerable<MachineAppraisal> GetAllMachineAppraisals();
        IEnumerable<MachineAppraisalDomainModel> GetAllMachineAppraisalDomainModels();
        MachineAppraisal GetMachineAppraisalById(int machineAppraisalId);

    }
}
